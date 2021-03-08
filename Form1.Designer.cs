
namespace Calculadora
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
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonigual = new System.Windows.Forms.Button();
            this.buttonpunto = new System.Windows.Forms.Button();
            this.buttoncero = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttondividir = new System.Windows.Forms.Button();
            this.buttonuno = new System.Windows.Forms.Button();
            this.buttondos = new System.Windows.Forms.Button();
            this.buttontres = new System.Windows.Forms.Button();
            this.buttonsumar = new System.Windows.Forms.Button();
            this.buttoncuatro = new System.Windows.Forms.Button();
            this.buttoncinco = new System.Windows.Forms.Button();
            this.buttonseis = new System.Windows.Forms.Button();
            this.buttonrestar = new System.Windows.Forms.Button();
            this.buttonsiete = new System.Windows.Forms.Button();
            this.buttonocho = new System.Windows.Forms.Button();
            this.buttonnueve = new System.Windows.Forms.Button();
            this.buttonmultiplicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Display = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCE.Location = new System.Drawing.Point(21, 358);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(101, 34);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonigual
            // 
            this.buttonigual.BackColor = System.Drawing.Color.Green;
            this.buttonigual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonigual.Location = new System.Drawing.Point(145, 358);
            this.buttonigual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(108, 34);
            this.buttonigual.TabIndex = 1;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = false;
            this.buttonigual.Click += new System.EventHandler(this.buttonigual_Click);
            // 
            // buttonpunto
            // 
            this.buttonpunto.Location = new System.Drawing.Point(27, 319);
            this.buttonpunto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonpunto.Name = "buttonpunto";
            this.buttonpunto.Size = new System.Drawing.Size(40, 33);
            this.buttonpunto.TabIndex = 2;
            this.buttonpunto.Text = ".";
            this.buttonpunto.UseVisualStyleBackColor = true;
            this.buttonpunto.Click += new System.EventHandler(this.buttonpunto_Click);
            // 
            // buttoncero
            // 
            this.buttoncero.Location = new System.Drawing.Point(84, 319);
            this.buttoncero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoncero.Name = "buttoncero";
            this.buttoncero.Size = new System.Drawing.Size(40, 33);
            this.buttoncero.TabIndex = 3;
            this.buttoncero.Text = "0";
            this.buttoncero.UseVisualStyleBackColor = true;
            this.buttoncero.Click += new System.EventHandler(this.buttoncero_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondelete.Location = new System.Drawing.Point(145, 319);
            this.buttondelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(55, 43);
            this.buttondelete.TabIndex = 4;
            this.buttondelete.Text = "←";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttondividir
            // 
            this.buttondividir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttondividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondividir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondividir.Location = new System.Drawing.Point(206, 319);
            this.buttondividir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttondividir.Name = "buttondividir";
            this.buttondividir.Size = new System.Drawing.Size(47, 43);
            this.buttondividir.TabIndex = 5;
            this.buttondividir.Text = "/";
            this.buttondividir.UseVisualStyleBackColor = false;
            this.buttondividir.Click += new System.EventHandler(this.buttondividir_Click);
            // 
            // buttonuno
            // 
            this.buttonuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonuno.Location = new System.Drawing.Point(27, 267);
            this.buttonuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonuno.Name = "buttonuno";
            this.buttonuno.Size = new System.Drawing.Size(40, 33);
            this.buttonuno.TabIndex = 6;
            this.buttonuno.Text = "1";
            this.buttonuno.UseVisualStyleBackColor = true;
            this.buttonuno.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttondos
            // 
            this.buttondos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondos.Location = new System.Drawing.Point(84, 267);
            this.buttondos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttondos.Name = "buttondos";
            this.buttondos.Size = new System.Drawing.Size(40, 33);
            this.buttondos.TabIndex = 7;
            this.buttondos.Text = "2";
            this.buttondos.UseVisualStyleBackColor = true;
            this.buttondos.Click += new System.EventHandler(this.buttondos_Click);
            // 
            // buttontres
            // 
            this.buttontres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontres.Location = new System.Drawing.Point(145, 267);
            this.buttontres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttontres.Name = "buttontres";
            this.buttontres.Size = new System.Drawing.Size(40, 33);
            this.buttontres.TabIndex = 8;
            this.buttontres.Text = "3";
            this.buttontres.UseVisualStyleBackColor = true;
            this.buttontres.Click += new System.EventHandler(this.buttontres_Click);
            // 
            // buttonsumar
            // 
            this.buttonsumar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsumar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsumar.Location = new System.Drawing.Point(206, 267);
            this.buttonsumar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonsumar.Name = "buttonsumar";
            this.buttonsumar.Size = new System.Drawing.Size(47, 48);
            this.buttonsumar.TabIndex = 9;
            this.buttonsumar.Text = "+";
            this.buttonsumar.UseVisualStyleBackColor = false;
            this.buttonsumar.Click += new System.EventHandler(this.buttonsumar_Click);
            // 
            // buttoncuatro
            // 
            this.buttoncuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncuatro.Location = new System.Drawing.Point(27, 213);
            this.buttoncuatro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoncuatro.Name = "buttoncuatro";
            this.buttoncuatro.Size = new System.Drawing.Size(40, 33);
            this.buttoncuatro.TabIndex = 10;
            this.buttoncuatro.Text = "4";
            this.buttoncuatro.UseVisualStyleBackColor = true;
            this.buttoncuatro.Click += new System.EventHandler(this.buttoncuatro_Click);
            // 
            // buttoncinco
            // 
            this.buttoncinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncinco.Location = new System.Drawing.Point(84, 213);
            this.buttoncinco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoncinco.Name = "buttoncinco";
            this.buttoncinco.Size = new System.Drawing.Size(40, 33);
            this.buttoncinco.TabIndex = 11;
            this.buttoncinco.Text = "5";
            this.buttoncinco.UseVisualStyleBackColor = true;
            this.buttoncinco.Click += new System.EventHandler(this.buttoncinco_Click);
            // 
            // buttonseis
            // 
            this.buttonseis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonseis.Location = new System.Drawing.Point(145, 213);
            this.buttonseis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonseis.Name = "buttonseis";
            this.buttonseis.Size = new System.Drawing.Size(40, 33);
            this.buttonseis.TabIndex = 12;
            this.buttonseis.Text = "6";
            this.buttonseis.UseVisualStyleBackColor = true;
            this.buttonseis.Click += new System.EventHandler(this.buttonseis_Click);
            // 
            // buttonrestar
            // 
            this.buttonrestar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrestar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonrestar.Location = new System.Drawing.Point(206, 213);
            this.buttonrestar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonrestar.Name = "buttonrestar";
            this.buttonrestar.Size = new System.Drawing.Size(47, 50);
            this.buttonrestar.TabIndex = 13;
            this.buttonrestar.Text = "-";
            this.buttonrestar.UseVisualStyleBackColor = false;
            this.buttonrestar.Click += new System.EventHandler(this.buttonrestar_Click);
            // 
            // buttonsiete
            // 
            this.buttonsiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsiete.Location = new System.Drawing.Point(27, 161);
            this.buttonsiete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonsiete.Name = "buttonsiete";
            this.buttonsiete.Size = new System.Drawing.Size(40, 33);
            this.buttonsiete.TabIndex = 14;
            this.buttonsiete.Text = "7";
            this.buttonsiete.UseVisualStyleBackColor = true;
            this.buttonsiete.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonocho
            // 
            this.buttonocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonocho.Location = new System.Drawing.Point(84, 161);
            this.buttonocho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonocho.Name = "buttonocho";
            this.buttonocho.Size = new System.Drawing.Size(40, 33);
            this.buttonocho.TabIndex = 15;
            this.buttonocho.Text = "8";
            this.buttonocho.UseVisualStyleBackColor = true;
            this.buttonocho.Click += new System.EventHandler(this.buttonocho_Click);
            // 
            // buttonnueve
            // 
            this.buttonnueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnueve.Location = new System.Drawing.Point(145, 161);
            this.buttonnueve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonnueve.Name = "buttonnueve";
            this.buttonnueve.Size = new System.Drawing.Size(40, 33);
            this.buttonnueve.TabIndex = 16;
            this.buttonnueve.Text = "9";
            this.buttonnueve.UseVisualStyleBackColor = true;
            this.buttonnueve.Click += new System.EventHandler(this.buttonnueve_Click);
            // 
            // buttonmultiplicar
            // 
            this.buttonmultiplicar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultiplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonmultiplicar.Location = new System.Drawing.Point(206, 161);
            this.buttonmultiplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonmultiplicar.Name = "buttonmultiplicar";
            this.buttonmultiplicar.Size = new System.Drawing.Size(47, 48);
            this.buttonmultiplicar.TabIndex = 17;
            this.buttonmultiplicar.Text = "*";
            this.buttonmultiplicar.UseVisualStyleBackColor = false;
            this.buttonmultiplicar.Click += new System.EventHandler(this.buttonmultiplicar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Display);
            this.panel1.Controls.Add(this.buttonmultiplicar);
            this.panel1.Controls.Add(this.buttonnueve);
            this.panel1.Controls.Add(this.buttonocho);
            this.panel1.Controls.Add(this.buttonsiete);
            this.panel1.Controls.Add(this.buttonrestar);
            this.panel1.Controls.Add(this.buttonseis);
            this.panel1.Controls.Add(this.buttoncinco);
            this.panel1.Controls.Add(this.buttoncuatro);
            this.panel1.Controls.Add(this.buttonsumar);
            this.panel1.Controls.Add(this.buttontres);
            this.panel1.Controls.Add(this.buttondos);
            this.panel1.Controls.Add(this.buttonuno);
            this.panel1.Controls.Add(this.buttondividir);
            this.panel1.Controls.Add(this.buttondelete);
            this.panel1.Controls.Add(this.buttoncero);
            this.panel1.Controls.Add(this.buttonpunto);
            this.panel1.Controls.Add(this.buttonigual);
            this.panel1.Controls.Add(this.buttonCE);
            this.panel1.Location = new System.Drawing.Point(19, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 409);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(20, 60);
            this.Display.Margin = new System.Windows.Forms.Padding(6);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(233, 58);
            this.Display.TabIndex = 18;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonigual;
        private System.Windows.Forms.Button buttonpunto;
        private System.Windows.Forms.Button buttoncero;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttondividir;
        private System.Windows.Forms.Button buttonuno;
        private System.Windows.Forms.Button buttondos;
        private System.Windows.Forms.Button buttontres;
        private System.Windows.Forms.Button buttonsumar;
        private System.Windows.Forms.Button buttoncuatro;
        private System.Windows.Forms.Button buttoncinco;
        private System.Windows.Forms.Button buttonseis;
        private System.Windows.Forms.Button buttonrestar;
        private System.Windows.Forms.Button buttonsiete;
        private System.Windows.Forms.Button buttonocho;
        private System.Windows.Forms.Button buttonnueve;
        private System.Windows.Forms.Button buttonmultiplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Display;
    }
}

