namespace employees
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dob = new DateTimePicker();
            image = new PictureBox();
            prevButton = new Button();
            nextButton = new Button();
            id = new TextBox();
            lastName = new TextBox();
            firstName = new TextBox();
            tz = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            phone = new TextBox();
            street = new TextBox();
            stNumber = new TextBox();
            mobile = new TextBox();
            city = new TextBox();
            deleteEmployeeButton = new Button();
            updataeEmployeeButton = new Button();
            addEmployeeButton = new Button();
            newEmployeeButton = new Button();
            saerchEmplyByTzButton = new Button();
            saerchEMplyByIdButton = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            gender = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            status = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            gender.SuspendLayout();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // dob
            // 
            dob.Location = new Point(31, 45);
            dob.Name = "dob";
            dob.Size = new Size(200, 23);
            dob.TabIndex = 0;
            // 
            // image
            // 
            image.Image = Properties.Resources.Lovepik_com_450044989_Vector_User_Management_Icon;
            image.Location = new Point(62, 111);
            image.Name = "image";
            image.Size = new Size(186, 158);
            image.TabIndex = 1;
            image.TabStop = false;
            // 
            // prevButton
            // 
            prevButton.Location = new Point(309, 264);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(145, 43);
            prevButton.TabIndex = 2;
            prevButton.Text = "<<";
            prevButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(517, 264);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(135, 43);
            nextButton.TabIndex = 3;
            nextButton.Text = ">>";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.Location = new Point(652, 45);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 4;
            // 
            // lastName
            // 
            lastName.Location = new Point(260, 45);
            lastName.Name = "lastName";
            lastName.Size = new Size(100, 23);
            lastName.TabIndex = 5;
            // 
            // firstName
            // 
            firstName.Location = new Point(387, 45);
            firstName.Name = "firstName";
            firstName.Size = new Size(100, 23);
            firstName.TabIndex = 6;
            // 
            // tz
            // 
            tz.Location = new Point(517, 45);
            tz.Name = "tz";
            tz.Size = new Size(100, 23);
            tz.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(679, 26);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 8;
            label1.Text = "קוד";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(540, 26);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "תעודת זהות";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 26);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 10;
            label3.Text = "שם פרטי";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 26);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 11;
            label4.Text = "שם משפחה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 26);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 12;
            label5.Text = "תאריך לידה";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(679, 123);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 348);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 15;
            label8.Text = "טלפון נייד";
            // 
            // phone
            // 
            phone.Location = new Point(497, 366);
            phone.Name = "phone";
            phone.Size = new Size(100, 23);
            phone.TabIndex = 25;
            phone.TextChanged += textBox5_TextChanged_1;
            // 
            // street
            // 
            street.Location = new Point(367, 366);
            street.Name = "street";
            street.Size = new Size(100, 23);
            street.TabIndex = 24;
            // 
            // stNumber
            // 
            stNumber.Location = new Point(240, 366);
            stNumber.Name = "stNumber";
            stNumber.Size = new Size(100, 23);
            stNumber.TabIndex = 23;
            // 
            // mobile
            // 
            mobile.Location = new Point(632, 366);
            mobile.Name = "mobile";
            mobile.Size = new Size(100, 23);
            mobile.TabIndex = 22;
            // 
            // city
            // 
            city.Location = new Point(120, 366);
            city.Name = "city";
            city.Size = new Size(100, 23);
            city.TabIndex = 26;
            // 
            // deleteEmployeeButton
            // 
            deleteEmployeeButton.Location = new Point(107, 436);
            deleteEmployeeButton.Name = "deleteEmployeeButton";
            deleteEmployeeButton.Size = new Size(141, 29);
            deleteEmployeeButton.TabIndex = 27;
            deleteEmployeeButton.Text = "מחיקת עובד";
            deleteEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // updataeEmployeeButton
            // 
            updataeEmployeeButton.Location = new Point(267, 436);
            updataeEmployeeButton.Name = "updataeEmployeeButton";
            updataeEmployeeButton.Size = new Size(141, 29);
            updataeEmployeeButton.TabIndex = 28;
            updataeEmployeeButton.Text = "עדכון";
            updataeEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.Location = new Point(428, 436);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(141, 29);
            addEmployeeButton.TabIndex = 29;
            addEmployeeButton.Text = "הוספת עובד";
            addEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // newEmployeeButton
            // 
            newEmployeeButton.Location = new Point(591, 436);
            newEmployeeButton.Name = "newEmployeeButton";
            newEmployeeButton.Size = new Size(141, 29);
            newEmployeeButton.TabIndex = 30;
            newEmployeeButton.Text = "חדש";
            newEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // saerchEmplyByTzButton
            // 
            saerchEmplyByTzButton.Location = new Point(446, 547);
            saerchEmplyByTzButton.Name = "saerchEmplyByTzButton";
            saerchEmplyByTzButton.Size = new Size(171, 43);
            saerchEmplyByTzButton.TabIndex = 31;
            saerchEmplyByTzButton.Text = "חיפוש עובד לפי תעודת זהות";
            saerchEmplyByTzButton.UseVisualStyleBackColor = true;
            // 
            // saerchEMplyByIdButton
            // 
            saerchEMplyByIdButton.Location = new Point(666, 547);
            saerchEMplyByIdButton.Name = "saerchEMplyByIdButton";
            saerchEMplyByIdButton.Size = new Size(161, 43);
            saerchEMplyByIdButton.TabIndex = 32;
            saerchEMplyByIdButton.Text = "חיפוש עובד לפי קוד";
            saerchEMplyByIdButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(520, 348);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 33;
            label9.Text = "טלפון בבית";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(394, 348);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 34;
            label10.Text = "רחוב";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(269, 348);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 35;
            label11.Text = "מספר";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(155, 348);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 36;
            label12.Text = "עיר";
            // 
            // gender
            // 
            gender.Controls.Add(radioButton2);
            gender.Controls.Add(radioButton1);
            gender.Location = new Point(591, 123);
            gender.Name = "gender";
            gender.Size = new Size(203, 110);
            gender.TabIndex = 37;
            gender.TabStop = false;
            gender.Text = "groupBox1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(74, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 19);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "נקבה";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(74, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "זכר";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            status.Controls.Add(radioButton6);
            status.Controls.Add(radioButton5);
            status.Controls.Add(radioButton4);
            status.Controls.Add(radioButton3);
            status.Location = new Point(309, 111);
            status.Name = "status";
            status.Size = new Size(211, 122);
            status.TabIndex = 38;
            status.TabStop = false;
            status.Text = "groupBox2";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(75, 78);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(51, 19);
            radioButton6.TabIndex = 25;
            radioButton6.TabStop = true;
            radioButton6.Text = "אלמן";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(75, 53);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(49, 19);
            radioButton5.TabIndex = 24;
            radioButton5.TabStop = true;
            radioButton5.Text = "גרוש";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(75, 28);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(45, 19);
            radioButton4.TabIndex = 23;
            radioButton4.TabStop = true;
            radioButton4.Text = "נשוי";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(75, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 19);
            radioButton3.TabIndex = 22;
            radioButton3.TabStop = true;
            radioButton3.Text = "רווק";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 625);
            Controls.Add(status);
            Controls.Add(gender);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(saerchEMplyByIdButton);
            Controls.Add(saerchEmplyByTzButton);
            Controls.Add(newEmployeeButton);
            Controls.Add(addEmployeeButton);
            Controls.Add(updataeEmployeeButton);
            Controls.Add(deleteEmployeeButton);
            Controls.Add(city);
            Controls.Add(phone);
            Controls.Add(street);
            Controls.Add(stNumber);
            Controls.Add(mobile);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tz);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(id);
            Controls.Add(nextButton);
            Controls.Add(prevButton);
            Controls.Add(image);
            Controls.Add(dob);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            gender.ResumeLayout(false);
            gender.PerformLayout();
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dob;
        private PictureBox image;
        private Button prevButton;
        private Button nextButton;
        private TextBox id;
        private TextBox lastName; 
        private TextBox firstName;
        private TextBox tz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox phone;
        private TextBox street;
        private TextBox stNumber;
        private TextBox mobile;
        private TextBox city;
        private Button deleteEmployeeButton;
        private Button updataeEmployeeButton;
        private Button addEmployeeButton;
        private Button newEmployeeButton;
        private Button saerchEmplyByTzButton;
        private Button saerchEMplyByIdButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox status;
        private GroupBox gender;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
    }
}