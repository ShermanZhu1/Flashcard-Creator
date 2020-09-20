using System;
using System.IO;
using System.Collections;

namespace Flashcard_fr_fr_fr
{
    partial class Form1
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
            this.cardText = new System.Windows.Forms.Label();
            this.flipButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.cardNum = new System.Windows.Forms.Label();
            this.deckBox = new System.Windows.Forms.ComboBox();
            this.chooseDeck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardText
            // 
            this.cardText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardText.AutoSize = true;
            this.cardText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardText.Location = new System.Drawing.Point(101, 114);
            this.cardText.Name = "cardText";
            this.cardText.Size = new System.Drawing.Size(0, 24);
            this.cardText.TabIndex = 0;
            this.cardText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(12, 12);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(75, 23);
            this.flipButton.TabIndex = 1;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.Flip_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(395, 318);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.Next_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(272, 318);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.Prev_Click);
            // 
            // cardNum
            // 
            this.cardNum.AutoSize = true;
            this.cardNum.Location = new System.Drawing.Point(353, 321);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(28, 17);
            this.cardNum.TabIndex = 4;
            this.cardNum.Text = "0/0";
            // 
            // deckBox
            // 
            this.deckBox.FormattingEnabled = true;
            this.deckBox.Location = new System.Drawing.Point(226, 12);
            this.deckBox.Name = "deckBox";
            this.deckBox.Size = new System.Drawing.Size(121, 24);
            this.deckBox.Items.AddRange(this.getDecknames());
            this.deckBox.TabIndex = 6;
            // 
            // chooseDeck
            // 
            this.chooseDeck.Location = new System.Drawing.Point(356, 12);
            this.chooseDeck.Name = "chooseDeck";
            this.chooseDeck.Size = new System.Drawing.Size(114, 23);
            this.chooseDeck.TabIndex = 7;
            this.chooseDeck.Text = "Choose Deck";
            this.chooseDeck.UseVisualStyleBackColor = true;
            this.chooseDeck.Click += new System.EventHandler(this.Decks_Box);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.chooseDeck);
            this.Controls.Add(this.deckBox);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.cardText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Flashcard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardText;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label cardNum;
        private System.Windows.Forms.ComboBox deckBox;
        private System.Windows.Forms.Button chooseDeck;
    }
}

