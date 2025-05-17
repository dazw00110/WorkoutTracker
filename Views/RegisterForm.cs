using System;
using System.Windows.Forms;

namespace WorkoutTracker.Views
{
    public partial class RegisterForm : Form
    {
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblBirthdate;
        private DateTimePicker dtpBirthdate;
        private Button btnRegister;

        public RegisterForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Workout Tracker - Rejestracja";
            this.Size = new System.Drawing.Size(400, 520); // zwiększyłem wysokość
            this.StartPosition = FormStartPosition.CenterScreen;

            int controlWidth = 300;

            lblTitle = new Label()
            {
                Text = "Rejestracja nowego użytkownika",
                Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                Width = controlWidth,
                Height = 40,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = false,
                Top = 20,
                Left = (this.ClientSize.Width - controlWidth) / 2
            };

            lblUsername = new Label()
            {
                Text = "Nazwa użytkownika:",
                Width = controlWidth,
                Top = lblTitle.Bottom + 20,
                Left = lblTitle.Left,
                AutoSize = false
            };

            txtUsername = new TextBox()
            {
                Width = controlWidth,
                Top = lblUsername.Bottom + 5,
                Left = lblUsername.Left
            };

            lblEmail = new Label()
            {
                Text = "Email:",
                Width = controlWidth,
                Top = txtUsername.Bottom + 15,
                Left = lblUsername.Left,
                AutoSize = false
            };

            txtEmail = new TextBox()
            {
                Width = controlWidth,
                Top = lblEmail.Bottom + 5,
                Left = lblUsername.Left
            };

            lblPassword = new Label()
            {
                Text = "Hasło:",
                Width = controlWidth,
                Top = txtEmail.Bottom + 15,
                Left = lblUsername.Left,
                AutoSize = false
            };

            txtPassword = new TextBox()
            {
                Width = controlWidth,
                Top = lblPassword.Bottom + 5,
                Left = lblUsername.Left,
                UseSystemPasswordChar = true
            };

            lblBirthdate = new Label()
            {
                Text = "Data urodzenia:",
                Width = controlWidth,
                Top = txtPassword.Bottom + 15,
                Left = lblUsername.Left,
                AutoSize = false
            };

            dtpBirthdate = new DateTimePicker()
            {
                Width = controlWidth,
                Top = lblBirthdate.Bottom + 5,
                Left = lblUsername.Left,
                Format = DateTimePickerFormat.Short,
                MaxDate = DateTime.Today,  // nie można wybrać przyszłej daty
                Value = DateTime.Today.AddYears(-18) // domyślnie 18 lat temu
            };

            btnRegister = new Button()
            {
                Text = "Zarejestruj się",
                Width = controlWidth,
                Top = dtpBirthdate.Bottom + 25,
                Left = lblUsername.Left
            };

            btnRegister.Click += BtnRegister_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, lblUsername, txtUsername,
                lblEmail, txtEmail,
                lblPassword, txtPassword,
                lblBirthdate, dtpBirthdate,
                btnRegister
            });
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Wypełnij wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie daty urodzenia (np. czy użytkownik ma co najmniej 13 lat)
            var birthdate = dtpBirthdate.Value.Date;
            var minDate = DateTime.Today.AddYears(-13);
            if (birthdate > minDate)
            {
                MessageBox.Show("Musisz mieć co najmniej 13 lat, aby się zarejestrować.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tutaj możesz przekazać birthdate do modelu User, np.:
            // var user = new User { ..., Birthdate = birthdate, ... };

            MessageBox.Show("Rejestracja zakończona sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
