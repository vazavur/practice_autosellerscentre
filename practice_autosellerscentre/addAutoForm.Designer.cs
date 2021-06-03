
namespace practice_autosellerscentre
{
    partial class addAutoForm
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
            this.markTB = new System.Windows.Forms.TextBox();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.engineTB = new System.Windows.Forms.TextBox();
            this.wheelTB = new System.Windows.Forms.TextBox();
            this.boxTB = new System.Windows.Forms.TextBox();
            this.VINTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // markTB
            // 
            this.markTB.Location = new System.Drawing.Point(32, 29);
            this.markTB.Name = "markTB";
            this.markTB.Size = new System.Drawing.Size(233, 20);
            this.markTB.TabIndex = 0;
            this.markTB.Text = "Марка";
            // 
            // modelTB
            // 
            this.modelTB.Location = new System.Drawing.Point(32, 66);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(233, 20);
            this.modelTB.TabIndex = 1;
            this.modelTB.Text = "Модель";
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(32, 103);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(233, 20);
            this.typeTB.TabIndex = 2;
            this.typeTB.Text = "Кузов";
            // 
            // engineTB
            // 
            this.engineTB.Location = new System.Drawing.Point(32, 139);
            this.engineTB.Name = "engineTB";
            this.engineTB.Size = new System.Drawing.Size(233, 20);
            this.engineTB.TabIndex = 3;
            this.engineTB.Text = "Двигатель";
            // 
            // wheelTB
            // 
            this.wheelTB.Location = new System.Drawing.Point(32, 177);
            this.wheelTB.Name = "wheelTB";
            this.wheelTB.Size = new System.Drawing.Size(233, 20);
            this.wheelTB.TabIndex = 4;
            this.wheelTB.Text = "Руль";
            // 
            // boxTB
            // 
            this.boxTB.Location = new System.Drawing.Point(32, 216);
            this.boxTB.Name = "boxTB";
            this.boxTB.Size = new System.Drawing.Size(233, 20);
            this.boxTB.TabIndex = 5;
            this.boxTB.Text = "Коробка";
            // 
            // VINTB
            // 
            this.VINTB.Location = new System.Drawing.Point(32, 255);
            this.VINTB.Name = "VINTB";
            this.VINTB.Size = new System.Drawing.Size(233, 20);
            this.VINTB.TabIndex = 6;
            this.VINTB.Text = "VIN";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 290);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(233, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(32, 322);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(233, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // addAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.VINTB);
            this.Controls.Add(this.boxTB);
            this.Controls.Add(this.wheelTB);
            this.Controls.Add(this.engineTB);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.modelTB);
            this.Controls.Add(this.markTB);
            this.Name = "addAutoForm";
            this.Text = "Добавить автомобиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox markTB;
        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.TextBox engineTB;
        private System.Windows.Forms.TextBox wheelTB;
        private System.Windows.Forms.TextBox boxTB;
        private System.Windows.Forms.TextBox VINTB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
    }
}