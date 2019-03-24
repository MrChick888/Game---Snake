namespace Game___Snake
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Board_pic = new System.Windows.Forms.PictureBox();
            this.Score_txt = new System.Windows.Forms.Label();
            this.Score_points = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOver_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Board_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Board_pic
            // 
            this.Board_pic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Board_pic.BackgroundImage = global::Game___Snake.Properties.Resources.Board;
            resources.ApplyResources(this.Board_pic, "Board_pic");
            this.Board_pic.Name = "Board_pic";
            this.Board_pic.TabStop = false;
            this.Board_pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_pic_Paint);
            // 
            // Score_txt
            // 
            resources.ApplyResources(this.Score_txt, "Score_txt");
            this.Score_txt.BackColor = System.Drawing.Color.Transparent;
            this.Score_txt.Name = "Score_txt";
            // 
            // Score_points
            // 
            resources.ApplyResources(this.Score_points, "Score_points");
            this.Score_points.BackColor = System.Drawing.Color.Transparent;
            this.Score_points.Name = "Score_points";
            // 
            // GameOver_txt
            // 
            resources.ApplyResources(this.GameOver_txt, "GameOver_txt");
            this.GameOver_txt.BackColor = System.Drawing.Color.Transparent;
            this.GameOver_txt.Name = "GameOver_txt";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game___Snake.Properties.Resources.Background;
            this.Controls.Add(this.GameOver_txt);
            this.Controls.Add(this.Score_points);
            this.Controls.Add(this.Score_txt);
            this.Controls.Add(this.Board_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Board_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Board_pic;
        private System.Windows.Forms.Label Score_txt;
        private System.Windows.Forms.Label Score_points;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label GameOver_txt;
    }
}

