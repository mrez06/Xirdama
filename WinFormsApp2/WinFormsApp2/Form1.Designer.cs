namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            lblMebleg = new Label();
            mtxtMebleg = new MaskedTextBox();
            panelSol = new Panel();
            btnXirdala = new Button();

            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();

            errorProvider1 = new ErrorProvider(components);

            panelSol.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();

            SuspendLayout();

            lblMebleg.AutoSize = true;
            lblMebleg.Font = new Font(
                "Mongolian Baiti",
                9F,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0
            );
            lblMebleg.ForeColor = Color.Black;
            lblMebleg.Location = new Point(23, 86);
            lblMebleg.Name = "lblMebleg";
            lblMebleg.Size = new Size(159, 16);
            lblMebleg.TabIndex = 0;
            lblMebleg.Text = "Xirdalanacaq mebleg";

            mtxtMebleg.Location = new Point(23, 127);
            mtxtMebleg.Name = "mtxtMebleg";
            mtxtMebleg.Size = new Size(125, 27);
            mtxtMebleg.TabIndex = 1;

            panelSol.BackColor = Color.FromArgb(255, 128, 0);
            panelSol.Controls.Add(btnXirdala);
            panelSol.Controls.Add(lblMebleg);
            panelSol.Controls.Add(mtxtMebleg);
            panelSol.Dock = DockStyle.Left;
            panelSol.Location = new Point(0, 0);
            panelSol.Name = "panelSol";
            panelSol.Size = new Size(233, 450);
            panelSol.TabIndex = 2;

            btnXirdala.Location = new Point(23, 171);
            btnXirdala.Name = "btnXirdala";
            btnXirdala.Size = new Size(94, 29);
            btnXirdala.TabIndex = 2;
            btnXirdala.Text = "Xirdala";
            btnXirdala.UseVisualStyleBackColor = true;

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(273, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;

            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;

            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(273, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;

            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(273, 307);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;

            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(571, 58);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;

            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(571, 138);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;

            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(571, 226);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(125, 62);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;

            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(571, 307);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(125, 62);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;

            label1.AutoSize = true;
            label1.Location = new Point(426, 82);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 11;
            label1.Text = "0";

            label2.AutoSize = true;
            label2.Location = new Point(426, 158);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 12;
            label2.Text = "0";

            label3.AutoSize = true;
            label3.Location = new Point(426, 249);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 13;
            label3.Text = "0";

            label4.AutoSize = true;
            label4.Location = new Point(426, 329);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 14;
            label4.Text = "0";

            label5.AutoSize = true;
            label5.Location = new Point(734, 82);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 15;
            label5.Text = "0";

            label6.AutoSize = true;
            label6.Location = new Point(734, 158);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 16;
            label6.Text = "0";

            label7.AutoSize = true;
            label7.Location = new Point(734, 249);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 17;
            label7.Text = "0";

            label8.AutoSize = true;
            label8.Location = new Point(734, 329);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 18;
            label8.Text = "0";

            errorProvider1.ContainerControl = this;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);

            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);

            Controls.Add(panelSol);

            Name = "Form1";
            Text = "Money";

            Load += Form1_Load;

            panelSol.ResumeLayout(false);
            panelSol.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMebleg;
        private MaskedTextBox mtxtMebleg;
        private Panel panelSol;
        private Button btnXirdala;

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;

        private ErrorProvider errorProvider1;
    }
}