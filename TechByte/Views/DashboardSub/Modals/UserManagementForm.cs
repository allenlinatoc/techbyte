using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Guitar32.Controllers;
using Guitar32.Database;
using Guitar32.Validations;
using Guitar32.Validations.Monitors;

using TechByte.Architecture.Validations;

namespace TechByte.Views.DashboardSub.Modals
{
    public partial class UserManagementForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private Architecture.Enums.FormModalTypes
            type = Architecture.Enums.FormModalTypes.Create;
        private object key;
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public UserManagementForm() : base(true) {
            InitializeComponent();
            this.InitializeMonitors();
            this.ResetFields();
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
            this.InitFormModal();
        }

        public void InitFormModal() {
            switch (this.type) {
                case Architecture.Enums.FormModalTypes.Create: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                    break;
                    }
                case Architecture.Enums.FormModalTypes.Update: {
                        lblTitle.Text = lblTitle.Text.Replace("{0}", "Edit");
                        break;
                    }
            }
        }

        public void Fetch() {
            
        }

        public void SetFormModalKey(object key) {
            this.key = key;
        }

        public void InitializeMonitors() {
            // {{ BLOCK for account details
            InputMonitor mUsername = new InputMonitor(txtUsername, true);
            InputMonitor mPassword2 = new InputMonitor(txtPassword2, true);
            InputMonitor mPassword1 = new InputMonitor(txtPassword1, true);
            mUsername.SetValidator(SingleWordAlphaNumeric.expression, SingleWordAlphaNumeric.message);
            mPassword1.SetValidator(Password.expression, Password.message);
            mPassword2.SetValidator(Password.expression, Password.message);
            // }}
            // {{ BLOCK for Personal information
            InputMonitor mFirstname = new InputMonitor(txtProfile_Firstname, true);
            InputMonitor mMiddlename = new InputMonitor(txtProfile_Middlename);
            InputMonitor mLastname = new InputMonitor(txtProfile_Lastname, true);
            InputMonitor mBirthplace = new InputMonitor(txtProfile_Birthplace);
            InputMonitor mNationality = new InputMonitor(txtProfile_Nationality, true);
            mFirstname.SetValidator(MultiWordAlpha.expression, MultiWordAlpha.message);
            mMiddlename.SetValidator(MultiWordAlpha.expression, MultiWordAlpha.message);
            mLastname.SetValidator(SingleWordAlphaNumeric.expression, SingleWordAlphaNumeric.message);
            mBirthplace.SetValidator(MultiWord.expression, MultiWord.message);
            mNationality.SetValidator(MultiWordAlpha.expression, MultiWordAlpha.message);
            // }}
            // {{ BLOCK for License cards
            InputMonitor mTIN = new InputMonitor(txtLicense_TIN, true);
            mTIN.SetValidator(TIN.expression, TIN.message);
            // }}
            // {{ BLOCK for Contact details
            InputMonitor mEmail = new InputMonitor(txtContact_Email, true);
            InputMonitor mFax = new InputMonitor(txtContact_Fax);
            InputMonitor mMobile = new InputMonitor(txtContact_Mobile);
            mEmail.SetValidator(Email.expression, Email.message);
            mFax.SetValidator(Fax.expression, Fax.message);
            mMobile.SetValidator(MobileNumber.expression, MobileNumber.message);
            // }}
            // {{ BLOCK for Address details
            InputMonitor mStreet = new InputMonitor(txtAddress_Street);
            InputMonitor mCity = new InputMonitor(txtAddress_City, true);
            InputMonitor mRegion = new InputMonitor(txtAddress_Region, true);
            InputMonitor mCountry = new InputMonitor(txtAddress_Country, true);
            mStreet.SetValidator(MultiWord.expression, MultiWord.message);
            mCity.SetValidator(MultiWordAlpha.expression, MultiWordAlpha.message);
            mRegion.SetValidator(MultiWordAlpha.expression, MultiWordAlpha.message);
            mCountry.SetValidator(MultiWordAlpha.expression, MultiWordAlpha.message);
            // }}


            this.AddInputMonitor(mUsername)
                .AddInputMonitor(mPassword1)
                .AddInputMonitor(mPassword2)
                // Personal info
                .AddInputMonitor(mFirstname)
                .AddInputMonitor(mMiddlename)
                .AddInputMonitor(mLastname)
                .AddInputMonitor(mNationality)
                .AddInputMonitor(mBirthplace)
                // License cards
                .AddInputMonitor(mTIN)
                // Contact details
                .AddInputMonitor(mFax)
                .AddInputMonitor(mEmail)
                .AddInputMonitor(mMobile)
                // Address details
                .AddInputMonitor(mStreet)
                .AddInputMonitor(mCity)
                .AddInputMonitor(mRegion)
                .AddInputMonitor(mCountry)
            ;
        }


        private void btnSubmit_Click(object sender, EventArgs e) {
            // Additional non-text inputs
            if (this.IsSubmittable()) {
                Guitar32.Validations.DateTime dt = Guitar32.Validations.DateTime.CreateFromDateTimePicker(dtProfile_Birthdate);

                TechByte.Controllers.NewUser ctrlNewUser = new Controllers.NewUser();
                ctrlNewUser.Register(comboPosition.SelectedItem.ToString(),
                    txtUsername.Text,
                    txtPassword1.Text,
                    txtPassword2.Text,
                    txtProfile_Firstname.Text,
                    txtProfile_Middlename.Text,
                    txtProfile_Lastname.Text,
                    comboProfile_Gender.SelectedItem.ToString().ToUpper(),
                    dt.getValue(),
                    txtProfile_Birthplace.Text,
                    txtProfile_Nationality.Text,
                    txtLicense_TIN.Text,
                    txtLicense_SSS.Text,
                    txtLicense_PAGIBIG.Text,
                    txtContact_Email.Text,
                    txtContact_Mobile.Text,
                    txtContact_Landline.Text,
                    txtContact_Fax.Text,
                    txtAddress_Street.Text,
                    txtAddress_City.Text,
                    txtAddress_Region.Text,
                    txtAddress_Country.Text);
                MessageBox.Show(ctrlNewUser.getResponse().GetMessage());
                if (ctrlNewUser.getResponse().GetCode() == "00") {
                    this.DisableCloseDetections();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }


    }
}
