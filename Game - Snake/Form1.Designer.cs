namespace Game___Snake
{
    partial class Background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Background));
            this.Board_pic = new System.Windows.Forms.PictureBox();
            this.Score_txt = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Board_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Board_pic
            // 
            this.Board_pic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.Board_pic, "Board_pic");
            this.Board_pic.Name = "Board_pic";
            this.Board_pic.TabStop = false;
            // 
            // Score_txt
            // 
            resources.ApplyResources(this.Score_txt, "Score_txt");
            this.Score_txt.BackColor = System.Drawing.Color.Transparent;
            this.Score_txt.Name = "Score_txt";
            // 
            // Points
            // 
            resources.ApplyResources(this.Points, "Points");
            this.Points.BackColor = System.Drawing.Color.Transparent;
            this.Points.Name = "Points";
            // 
            // Background
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game___Snake.Properties.Resources.Background;
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Score_txt);
            this.Controls.Add(this.Board_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Background";
            ((System.ComponentModel.ISupportInitialize)(this.Board_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Board_pic;
        private System.Windows.Forms.Label Score_txt;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Timer gameTimer;
    }
}

