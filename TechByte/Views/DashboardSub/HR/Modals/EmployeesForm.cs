using Guitar32;
using Guitar32.Controllers;
using Guitar32.Database;
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
using TechByte.Architecture;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Profiles;

namespace TechByte.Views.DashboardSub.HR.Modals
{
    public partial class EmployeesForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private Architecture.Enums.FormModalTypes type;
        private int key;
        private Guitar32.Data.ComboBind comboBind_Gender;


        public EmployeesForm() : base(true) {
            InitializeComponent();
            this.type = Architecture.Enums.FormModalTypes.Create;
        }

        private void EmployeesForm_Load(object sender, EventArgs e) {
            InitFormModal();
            Fetch();
            // Initialize monitors
            this.AddInputMonitor(new InputMonitor(txtProfile_Firstname, true))
                .AddInputMonitor(new InputMonitor(txtProfile_Lastname, true))
                .AddInputMonitor(new InputMonitor(txtProfile_Nationality, true))
                .AddInputMonitor(new InputMonitor(txtLicense_TIN, true))
                .AddInputMonitor(new InputMonitor(txtContact_Email, true))
                .AddInputMonitor(new InputMonitor(txtAddress_Region, true))
                .AddInputMonitor(new InputMonitor(txtAddress_City, true))
                .AddInputMonitor(new InputMonitor(txtAddress_Country, true))
            ;
        }

        public void Fetch() {
            if (this.type == Architecture.Enums.FormModalTypes.Update) {
                SystemUser user = new SystemUser(this.key);
                ProfileDetails profile = user.getProfileDetails();
                txtProfile_Firstname.Text = profile.getFullname().getFirstName();
                txtProfile_Middlename.Text = profile.getFullname().getMiddleName();
                txtProfile_Lastname.Text = profile.getFullname().getLastName();
                txtProfile_Nationality.Text = profile.getNationality();
                txtProfile_Birthplace.Text = profile.getBirthPlace();
                comboBind_Gender.SetByValue(profile.getGender());
                dtProfile_Birthdate.Value = System.DateTime.Parse(profile.getBirthDate());

                txtLicense_TIN.Text = profile.getTIN();
                txtLicense_PAGIBIG.Text = profile.getPAGIBIG();
                txtLicense_SSS.Text = profile.getSSS();
                txtContact_Email.Text = profile.getContactDetails().getEmail();
                txtContact_Mobile.Text = profile.getContactDetails().getMobile();
                txtContact_Fax.Text = profile.getContactDetails().getFax();
                txtContact_Landline.Text = profile.getContactDetails().getLandline();
                txtAddress_Street.Text = profile.getAddressDetails().getStreet();
                txtAddress_City.Text = profile.getAddressDetails().getCity();
                txtAddress_Region.Text = profile.getAddressDetails().getRegion();
                txtAddress_Country.Text = profile.getAddressDetails().getCountry();
            }
        }

        public void SetFormModalKey(object key) {
            this.key = Integer.Parse(key);
            this.SetFormModalType(Architecture.Enums.FormModalTypes.Update);
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            switch (this.type) {
                case Architecture.Enums.FormModalTypes.Create: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "Create");
                    this.Text = this.Text.Replace("{0}", "Create");
                    break;
                }
                case Architecture.Enums.FormModalTypes.Update: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "Edit");
                    this.Text = this.Text.Replace("{0}", "Edit");
                    this.DisableCloseDetections();
                    break;
                }
            }
            this.comboBind_Gender = new Guitar32.Data.ComboBind(ref comboProfile_Gender);
            comboBind_Gender
                .AddItem("Male", new Gender("MALE").getValue())
                .AddItem("Female", new Gender("FEMALE").getValue())
            ;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (this.IsSubmittable()) {
                SystemUser user = new SystemUser(this.key);
                ProfileDetails profile = user.getProfileDetails();
                Fullname fullname = profile.getFullname();
                fullname.setFirstName(new MultiWordAlpha(txtProfile_Firstname.Text));
                fullname.setMiddleName(new MultiWordAlpha(txtProfile_Middlename.Text));
                fullname.setLastName(new MultiWordAlpha(txtProfile_Lastname.Text));
                profile.setFullname(fullname);
                profile.setNationality(new MultiWordAlpha(txtProfile_Nationality.Text));
                profile.setBirthPlace(new MultiWord(txtProfile_Birthplace.Text));
                profile.setBirthDate(Guitar32.Validations.DateTime.CreateFromDateTimePicker(dtProfile_Birthdate, true));
                profile.setTIN(new Architecture.Validations.TIN(txtLicense_TIN.Text));
                profile.setPAGIBIG(txtLicense_PAGIBIG.Text);
                profile.setSSS(txtLicense_SSS.Text);
                profile.setGender(new Gender(this.comboBind_Gender.GetValue().ToString()));
                AddressDetails address = profile.getAddressDetails();
                address.setStreet(new MultiWord(txtAddress_Street.Text));
                address.setCity(new MultiWordAlpha(txtAddress_City.Text));
                address.setRegion(new MultiWordAlpha(txtAddress_Region.Text));
                address.setCountry(new MultiWordAlpha(txtAddress_Country.Text));
                profile.setAddressDetails(address);
                ContactDetails contact = profile.getContactDetails();
                contact.setMobile(new Architecture.Validations.MobileNumber(txtContact_Mobile.Text));
                contact.setEmail(new Email(txtContact_Email.Text));
                contact.setLandline(txtContact_Landline.Text);
                contact.setFax(txtContact_Fax.Text);
                profile.setContactDetails(contact);
                user.setProfileDetails(profile);
                if (user.Update()) {
                    MessageBox.Show("Changes have been successfully saved!");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else {
                    MessageBox.Show("Unable to save changes, make sure you are connected to server");
                }
            }
        }
    }
}
