
namespace Proyecto_FicherosCSHARP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentrouteLBL = new System.Windows.Forms.Label();
            this.currentrouteTXT = new System.Windows.Forms.TextBox();
            this.filesfolderBTN = new System.Windows.Forms.Button();
            this.filesfolderLIST = new System.Windows.Forms.ListBox();
            this.crearBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.moveBTN = new System.Windows.Forms.Button();
            this.filesCHK = new System.Windows.Forms.RadioButton();
            this.folderCHK = new System.Windows.Forms.RadioButton();
            this.routeLBL = new System.Windows.Forms.Label();
            this.routeTXT = new System.Windows.Forms.TextBox();
            this.showfileBTN = new System.Windows.Forms.Button();
            this.modifyfileBTN = new System.Windows.Forms.Button();
            this.contentfileTXT = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentrouteLBL
            // 
            this.currentrouteLBL.AutoSize = true;
            this.currentrouteLBL.Location = new System.Drawing.Point(12, 16);
            this.currentrouteLBL.Name = "currentrouteLBL";
            this.currentrouteLBL.Size = new System.Drawing.Size(84, 13);
            this.currentrouteLBL.TabIndex = 0;
            this.currentrouteLBL.Text = "Directorio actual";
            // 
            // currentrouteTXT
            // 
            this.currentrouteTXT.Location = new System.Drawing.Point(103, 13);
            this.currentrouteTXT.Name = "currentrouteTXT";
            this.currentrouteTXT.Size = new System.Drawing.Size(685, 20);
            this.currentrouteTXT.TabIndex = 1;
            // 
            // filesfolderBTN
            // 
            this.filesfolderBTN.Location = new System.Drawing.Point(16, 50);
            this.filesfolderBTN.Name = "filesfolderBTN";
            this.filesfolderBTN.Size = new System.Drawing.Size(180, 25);
            this.filesfolderBTN.TabIndex = 2;
            this.filesfolderBTN.Text = "Listar carpetas y ficheros";
            this.filesfolderBTN.UseVisualStyleBackColor = true;
            this.filesfolderBTN.Click += new System.EventHandler(this.filesfolderBTN_Click);
            // 
            // filesfolderLIST
            // 
            this.filesfolderLIST.FormattingEnabled = true;
            this.filesfolderLIST.Location = new System.Drawing.Point(16, 81);
            this.filesfolderLIST.Name = "filesfolderLIST";
            this.filesfolderLIST.Size = new System.Drawing.Size(772, 121);
            this.filesfolderLIST.TabIndex = 3;
            // 
            // crearBTN
            // 
            this.crearBTN.Location = new System.Drawing.Point(16, 217);
            this.crearBTN.Name = "crearBTN";
            this.crearBTN.Size = new System.Drawing.Size(140, 25);
            this.crearBTN.TabIndex = 4;
            this.crearBTN.Text = "Crear";
            this.crearBTN.UseVisualStyleBackColor = true;
            this.crearBTN.Click += new System.EventHandler(this.crearBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(162, 217);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(140, 25);
            this.deleteBTN.TabIndex = 5;
            this.deleteBTN.Text = "Eliminar";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // moveBTN
            // 
            this.moveBTN.Location = new System.Drawing.Point(308, 217);
            this.moveBTN.Name = "moveBTN";
            this.moveBTN.Size = new System.Drawing.Size(140, 25);
            this.moveBTN.TabIndex = 6;
            this.moveBTN.Text = "Renombrar/Mover";
            this.moveBTN.UseVisualStyleBackColor = true;
            this.moveBTN.Click += new System.EventHandler(this.moveBTN_Click);
            // 
            // filesCHK
            // 
            this.filesCHK.AutoSize = true;
            this.filesCHK.Location = new System.Drawing.Point(16, 260);
            this.filesCHK.Name = "filesCHK";
            this.filesCHK.Size = new System.Drawing.Size(65, 17);
            this.filesCHK.TabIndex = 7;
            this.filesCHK.TabStop = true;
            this.filesCHK.Text = "Ficheros";
            this.filesCHK.UseVisualStyleBackColor = true;
            // 
            // folderCHK
            // 
            this.folderCHK.AutoSize = true;
            this.folderCHK.Location = new System.Drawing.Point(103, 260);
            this.folderCHK.Name = "folderCHK";
            this.folderCHK.Size = new System.Drawing.Size(62, 17);
            this.folderCHK.TabIndex = 8;
            this.folderCHK.TabStop = true;
            this.folderCHK.Text = "Carpeta";
            this.folderCHK.UseVisualStyleBackColor = true;
            // 
            // routeLBL
            // 
            this.routeLBL.AutoSize = true;
            this.routeLBL.Location = new System.Drawing.Point(12, 298);
            this.routeLBL.Name = "routeLBL";
            this.routeLBL.Size = new System.Drawing.Size(96, 13);
            this.routeLBL.TabIndex = 9;
            this.routeLBL.Text = "Directorio o fichero";
            // 
            // routeTXT
            // 
            this.routeTXT.Location = new System.Drawing.Point(114, 295);
            this.routeTXT.Name = "routeTXT";
            this.routeTXT.Size = new System.Drawing.Size(674, 20);
            this.routeTXT.TabIndex = 10;
            // 
            // showfileBTN
            // 
            this.showfileBTN.Location = new System.Drawing.Point(15, 332);
            this.showfileBTN.Name = "showfileBTN";
            this.showfileBTN.Size = new System.Drawing.Size(140, 25);
            this.showfileBTN.TabIndex = 11;
            this.showfileBTN.Text = "Visualizar fichero";
            this.showfileBTN.UseVisualStyleBackColor = true;
            this.showfileBTN.Click += new System.EventHandler(this.showfileBTN_Click);
            // 
            // modifyfileBTN
            // 
            this.modifyfileBTN.Location = new System.Drawing.Point(162, 332);
            this.modifyfileBTN.Name = "modifyfileBTN";
            this.modifyfileBTN.Size = new System.Drawing.Size(140, 25);
            this.modifyfileBTN.TabIndex = 12;
            this.modifyfileBTN.Text = "Modificar fichero";
            this.modifyfileBTN.UseVisualStyleBackColor = true;
            this.modifyfileBTN.Click += new System.EventHandler(this.modifyfileBTN_Click);
            // 
            // contentfileTXT
            // 
            this.contentfileTXT.Location = new System.Drawing.Point(16, 373);
            this.contentfileTXT.Multiline = true;
            this.contentfileTXT.Name = "contentfileTXT";
            this.contentfileTXT.Size = new System.Drawing.Size(772, 199);
            this.contentfileTXT.TabIndex = 13;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(308, 584);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(180, 15);
            this.autor.TabIndex = 14;
            this.autor.Text = "Realizado por Ayoze Amaro Estévez";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.contentfileTXT);
            this.Controls.Add(this.modifyfileBTN);
            this.Controls.Add(this.showfileBTN);
            this.Controls.Add(this.routeTXT);
            this.Controls.Add(this.routeLBL);
            this.Controls.Add(this.folderCHK);
            this.Controls.Add(this.filesCHK);
            this.Controls.Add(this.moveBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.crearBTN);
            this.Controls.Add(this.filesfolderLIST);
            this.Controls.Add(this.filesfolderBTN);
            this.Controls.Add(this.currentrouteTXT);
            this.Controls.Add(this.currentrouteLBL);
            this.Name = "Form1";
            this.Text = "Proyecto de Ficheros con C#";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentrouteLBL;
        private System.Windows.Forms.TextBox currentrouteTXT;
        private System.Windows.Forms.Button filesfolderBTN;
        private System.Windows.Forms.ListBox filesfolderLIST;
        private System.Windows.Forms.Button crearBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button moveBTN;
        private System.Windows.Forms.RadioButton filesCHK;
        private System.Windows.Forms.RadioButton folderCHK;
        private System.Windows.Forms.Label routeLBL;
        private System.Windows.Forms.TextBox routeTXT;
        private System.Windows.Forms.Button showfileBTN;
        private System.Windows.Forms.Button modifyfileBTN;
        private System.Windows.Forms.TextBox contentfileTXT;
        private System.Windows.Forms.Label autor;
    }
}

