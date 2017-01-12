namespace AbstractFactory
{
    partial class AbstractFactoryExample
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.oleDBDatabase = new System.Windows.Forms.RadioButton();
            this.SqlServerDatabase = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oleDBDatabase
            // 
            this.oleDBDatabase.AutoSize = true;
            this.oleDBDatabase.Location = new System.Drawing.Point(51, 37);
            this.oleDBDatabase.Name = "oleDBDatabase";
            this.oleDBDatabase.Size = new System.Drawing.Size(93, 17);
            this.oleDBDatabase.TabIndex = 0;
            this.oleDBDatabase.TabStop = true;
            this.oleDBDatabase.Text = "OleDBDabase";
            this.oleDBDatabase.UseVisualStyleBackColor = true;
            // 
            // SqlServerDatabase
            // 
            this.SqlServerDatabase.AutoSize = true;
            this.SqlServerDatabase.Location = new System.Drawing.Point(51, 75);
            this.SqlServerDatabase.Name = "SqlServerDatabase";
            this.SqlServerDatabase.Size = new System.Drawing.Size(117, 17);
            this.SqlServerDatabase.TabIndex = 1;
            this.SqlServerDatabase.TabStop = true;
            this.SqlServerDatabase.Text = "SqlServerDatabase";
            this.SqlServerDatabase.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AbstractFactoryExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SqlServerDatabase);
            this.Controls.Add(this.oleDBDatabase);
            this.Name = "AbstractFactoryExample";
            this.Text = "Abstract Factory Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton oleDBDatabase;
        private System.Windows.Forms.RadioButton SqlServerDatabase;
        private System.Windows.Forms.Button button1;
    }
}

