using Guitar32.Controllers;
using Guitar32.Database;
using Guitar32.Validations;
using Guitar32.Validations.Monitors;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Architecture;
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Profiles;
using TechByte.Architecture.Validations;


namespace TechByte.Views.DashboardSub.Admin.Modals
{
    public partial class UserManagementForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private Architecture.Enums.FormModalTypes
            type = Architecture.Enums.FormModalTypes.Create;
        private int key;
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public UserManagementForm() : base(true) {
            InitializeComponent();
            this.ResetFields();
        }

        private void UserManagementForm_Load(object sender, EventArgs e) {
            this.InitializeMonitors();
            if (this.type == Architecture.Enums.FormModalTypes.Update) {
                Fetch();
            }
        }

        public void InitFormModal() {
            switch (this.type) {
                case Architecture.Enums.FormModalTypes.Create: {
                        lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                        btnSubmit.Text = "Save";
                        break;
                    }
                case Architecture.Enums.FormModalTypes.Update: {
                        lblTitle.Text = lblTitle.Text.Replace("{0}", "Edit");
                        btnSubmit.Text = "Save changes";
                        btnCancel.Text = "Close";
                        this.DisableCloseDetections();
                        break;
                    }
            }
        }

        public void Fetch() {
            SystemUser user = new SystemUser(this.key);
            // account
            txtUsername.Text = user.getUsername();
            comboPosition.SelectedItem = user.getPower().Trim().ToUpper();
            // profile
            txtProfile_Firstname.Text = user.getProfile().getFullname().getFirstName();
            txtProfile_Middlename.Text = user.getProfile().getFullname().getMiddleName();
            txtProfile_Lastname.Text = user.getProfile().getFullname().getLastName();
            txtProfile_Birthplace.Text = user.getProfile().getBirthPlace();
            dtProfile_Birthdate.Value = System.DateTime.Parse(user.getProfile().getBirthDate());
            txtProfile_Nationality.Text = user.getProfile().getNationality();
            // license
            txtLicense_TIN.Text = user.getProfile().getTIN();
            txtLicense_SSS.Text = user.getProfile().getSSS();
            txtLicense_PAGIBIG.Text = user.getProfile().getPAGIBIG();
            // contact details
            txtContact_Email.Text = user.getProfile().getContactDetails().getEmail();
            txtContact_Mobile.Text = user.getProfile().getContactDetails().getMobile();
            txtContact_Landline.Text = user.getProfile().getContactDetails().getLandline();
            txtContact_Fax.Text = user.getProfile().getContactDetails().getFax();
            // address details
            txtAddress_Street.Text = user.getProfile().getAddressDetails().getStreet();
            txtAddress_City.Text = user.getProfile().getAddressDetails().getCity();
            txtAddress_Region.Text = user.getProfile().getAddressDetails().getRegion();
            txtAddress_Country.Text = user.getProfile().getAddressDetails().getCountry();
        }

        public void SetFormModalKey(object key) {
            this.key = (int)key;
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
            this.InitFormModal();
        }

        public void InitializeMonitors() {
            // {{ BLOCK for account details
            InputMonitor mUsername = new InputMonitor(txtUsername, true);
            mUsername.SetValidator(SingleWordAlphaNumeric.expression, SingleWordAlphaNumeric.message);
            if (this.type == Architecture.Enums.FormModalTypes.Create) {
                InputMonitor mPassword2 = new InputMonitor(txtPassword2, true);
                InputMonitor mPassword1 = new InputMonitor(txtPassword1, true);
                mPassword1.SetValidator(Password.expression, Password.message);
                mPassword2.SetValidator(Password.expression, Password.message);
                this.AddInputMonitor(mPassword1);
                this.AddInputMonitor(mPassword2);
            }
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
            // Check password match
            if (txtPassword1.TextLength > 0 || txtPassword2.TextLength > 0) {
                if (!txtPassword1.Text.Equals(txtPassword2.Text)) {
                    MessageBox.Show("Passwords didn't matched, please check and try again");
                    return;
                }
            }

            // Additional non-text inputs
            if (this.IsSubmittable()) {
                if (this.type == Architecture.Enums.FormModalTypes.Create) {
                    // Create
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
                else {
                    SystemUser user = new SystemUser(this.key);

                    // Update password if it has contents
                    if (txtPassword1.TextLength > 0 || txtPassword2.TextLength > 0) {
                        // Prompt user
                        DialogResult answer =
                            MessageBox.Show("You entered a password, this means you want to change this user's password. Are you sure you want to proceed?", "Confirm change password", MessageBoxButtons.YesNo);
                        if (answer == System.Windows.Forms.DialogResult.No) {
                            return;
                        }
                        user.setPassword(new Password(txtPassword1.Text, true));
                        user.UpdatePassword();
                    }
                    // Update
                    user.setUsername(new SingleWordAlphaNumeric(txtUsername.Text, true));
                    user.setPower(new Architecture.Validations.UserPower(comboPosition.SelectedItem.ToString(), true));
                    ProfileDetails profileDetails = user.getProfile();
                    Fullname profileDetails_Fullname = profileDetails.getFullname();
                    AddressDetails addressDetails = profileDetails.getAddressDetails();
                    ContactDetails contactDetails = profileDetails.getContactDetails();
                    profileDetails_Fullname.setFirstName(new MultiWordAlpha(txtProfile_Firstname.Text, true));
                    profileDetails_Fullname.setMiddleName(new MultiWordAlpha(txtProfile_Middlename.Text, true));
                    profileDetails_Fullname.setLastName(new MultiWordAlpha(txtProfile_Lastname.Text, true));
                    profileDetails.setFullname(profileDetails_Fullname);
                    profileDetails.setBirthDate(Guitar32.Validations.DateTime.CreateFromDateTimePicker(dtProfile_Birthdate));
                    profileDetails.setBirthPlace(new MultiWord(txtProfile_Birthplace.Text, true));
                    profileDetails.setNationality(new MultiWordAlpha(txtProfile_Nationality.Text, true));
                    profileDetails.setGender(new Gender(comboProfile_Gender.SelectedItem.ToString(), true));
                    profileDetails.setTIN(new TIN(txtLicense_TIN.Text, true));
                    profileDetails.setSSS(txtLicense_SSS.Text);
                    profileDetails.setPAGIBIG(txtLicense_PAGIBIG.Text);
                    contactDetails.setEmail(new Email(txtContact_Email.Text, true));
                    contactDetails.setMobile(new MobileNumber(txtContact_Mobile.Text, true));
                    contactDetails.setLandline(txtContact_Landline.Text);
                    contactDetails.setFax(txtContact_Fax.Text);
                    addressDetails.setStreet(new MultiWord(txtAddress_Street.Text, true));
                    addressDetails.setCity(new MultiWordAlpha(txtAddress_City.Text, true));
                    addressDetails.setRegion(new MultiWordAlpha(txtAddress_Region.Text, true));
                    addressDetails.setCountry(new MultiWordAlpha(txtAddress_Country.Text, true));
                    profileDetails.setContactDetails(contactDetails);
                    profileDetails.setAddressDetails(addressDetails);
                    if (!user.Update()) {
                        MessageBox.Show("Something went wrong, please check your connection and try again");
                        return;
                    }
                    MessageBox.Show("Changes have been successfully saved!");
                    this.DisableCloseDetections();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }


    }
}
