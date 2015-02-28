using Guitar32.Controllers;
using Guitar32.Utilities;
using Guitar32.Validations;
using Guitar32.Validations.Monitors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Profiles;

namespace TechByte.Views.DashboardSub.Admin.Modals
{
    public partial class BusinessPartnersForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private int key;
        private Architecture.Enums.FormModalTypes type = Architecture.Enums.FormModalTypes.Create;

        public BusinessPartnersForm() : base(true) {
            InitializeComponent();
            this.GetInputMonitors().Clear();
        }

        private void BusinessPartnersForm_Load(object sender, EventArgs e) {
            InitFormModal();
            this.ResetFields(new Control[] { txtAddress_Country });
            this.AddInputMonitor(new InputMonitor(txtCompany_Name, true));
            this.AddInputMonitor(new InputMonitor(txtContact_Email, true));
            this.AddInputMonitor(new InputMonitor(txtAddress_City, true));
            this.AddInputMonitor(new InputMonitor(txtAddress_Region, true));
            this.AddInputMonitor(new InputMonitor(txtAddress_Country, true));
            // Fetch if UPDATE mode
            Fetch();
        }

        public void Fetch() {
            if (this.type == Architecture.Enums.FormModalTypes.Update) {
                Company company = new Company(this.key);
                txtCompany_Name.Text = company.getName();
                comboCompany_Type.SelectedItem = Strings.UppercaseFirst(company.getType());
                txtContact_Email.Text = company.getContactDetails().getEmail();
                txtContact_Mobile.Text = company.getContactDetails().getMobile();
                txtContact_Fax.Text = company.getContactDetails().getFax();
                txtContact_Landline.Text = company.getContactDetails().getLandline();
                txtAddress_Street.Text = company.getAddressDetails().getStreet();
                txtAddress_City.Text = company.getAddressDetails().getCity();
                txtAddress_Region.Text = company.getAddressDetails().getRegion();
                txtAddress_Country.Text = company.getAddressDetails().getCountry();
            }
        }

        public void SetFormModalKey(object key) {
            this.key = Integer.Parse(key);
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            switch (this.type) {
                case Architecture.Enums.FormModalTypes.Create: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                    break;
                    }
                case Architecture.Enums.FormModalTypes.Update: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "Edit");
                    btnCancel.Text = "Close";
                    this.DisableCloseDetections();
                    break;
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            // Check if required fields were satisfied
            if (!this.IsSubmittable()) {
                return;
            }

            AddressDetails addressDetails = new AddressDetails();
            ContactDetails contactDetails = new ContactDetails();
            Company company = new Company();
            if (this.type == Architecture.Enums.FormModalTypes.Update) {
                company = new Company(this.key);
                addressDetails = company.getAddressDetails();
                contactDetails = company.getContactDetails();
            }
            
            // {{ BLOCK for Address details
            addressDetails.setStreet(new MultiWord(txtAddress_Street.Text));
            addressDetails.setCity(new MultiWordAlpha(txtAddress_City.Text));
            addressDetails.setRegion(new MultiWordAlpha(txtAddress_Region.Text));
            addressDetails.setCountry(new MultiWordAlpha(txtAddress_Country.Text));
            // }}
            // {{ BLOCK for Contact details
            contactDetails.setEmail(new Email(txtContact_Email.Text));
            contactDetails.setMobile(new Architecture.Validations.MobileNumber(txtContact_Mobile.Text));
            contactDetails.setLandline(txtContact_Landline.Text);
            contactDetails.setFax(txtContact_Fax.Text);
            // }}
            // {{ BLOCK for Company
            company.setName(new MultiWord(txtCompany_Name.Text));
            company.setType(new MultiWordAlpha(comboCompany_Type.SelectedItem.ToString()));
            company.setAddressDetails(addressDetails);
            company.setContactDetails(contactDetails);
            // }}

            if (this.type == Architecture.Enums.FormModalTypes.Create) {
                bool companyCreateSuccess = company.CreateData();
                if (!companyCreateSuccess) {
                    MessageBox.Show("Unable to create company entry. Please check your connection and try again");
                    return;
                }
                MessageBox.Show("Company entry for " + Strings.Surround(company.getName()) + " has been successfully created!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.DisableCloseDetections();
                this.Close();
            }
            else if (type == Architecture.Enums.FormModalTypes.Update) {
                bool companyUpdateSuccess = company.Update();
                if (!companyUpdateSuccess) {
                    MessageBox.Show("Unable to update changes. Please check your connnection and try again");
                    return;
                }
                MessageBox.Show("Changes have been successfully saved!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("Unknown modal type, please contact administrator for further assistance");
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
