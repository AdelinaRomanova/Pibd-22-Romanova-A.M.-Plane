﻿
namespace AircraftPlantView
{
	partial class FormPlaneComponent
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxComponent = new System.Windows.Forms.ComboBox();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Компонет:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Количество:";
			// 
			// comboBoxComponent
			// 
			this.comboBoxComponent.FormattingEnabled = true;
			this.comboBoxComponent.Location = new System.Drawing.Point(134, 15);
			this.comboBoxComponent.Name = "comboBoxComponent";
			this.comboBoxComponent.Size = new System.Drawing.Size(312, 28);
			this.comboBoxComponent.TabIndex = 2;
			// 
			// textBoxCount
			// 
			this.textBoxCount.Location = new System.Drawing.Point(134, 60);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(312, 27);
			this.textBoxCount.TabIndex = 3;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(231, 102);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(103, 32);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(340, 102);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(96, 32);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormPlaneComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 144);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxCount);
			this.Controls.Add(this.comboBoxComponent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormPlaneComponent";
			this.Text = "Компонент изделия";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxComponent;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
	}
}