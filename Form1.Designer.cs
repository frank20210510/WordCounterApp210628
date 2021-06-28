
namespace WordCounterApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_createWordList = new System.Windows.Forms.Button();
            this.btn_sortWordList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_countWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Load a Text File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Split the File into Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "3.Count the Frequency of Each Word";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(59, 57);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(91, 23);
            this.btn_chooseFile.TabIndex = 3;
            this.btn_chooseFile.Text = "Choose a File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(194, 57);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 412);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_createWordList
            // 
            this.btn_createWordList.Location = new System.Drawing.Point(324, 57);
            this.btn_createWordList.Name = "btn_createWordList";
            this.btn_createWordList.Size = new System.Drawing.Size(96, 23);
            this.btn_createWordList.TabIndex = 6;
            this.btn_createWordList.Text = "Create Word List";
            this.btn_createWordList.UseVisualStyleBackColor = true;
            this.btn_createWordList.Click += new System.EventHandler(this.btn_createWordList_Click);
            // 
            // btn_sortWordList
            // 
            this.btn_sortWordList.Location = new System.Drawing.Point(427, 56);
            this.btn_sortWordList.Name = "btn_sortWordList";
            this.btn_sortWordList.Size = new System.Drawing.Size(75, 23);
            this.btn_sortWordList.TabIndex = 7;
            this.btn_sortWordList.Text = "Sort Words";
            this.btn_sortWordList.UseVisualStyleBackColor = true;
            this.btn_sortWordList.Click += new System.EventHandler(this.btn_sortWordList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(324, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 412);
            this.listBox1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(671, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 412);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_countWords
            // 
            this.btn_countWords.Location = new System.Drawing.Point(671, 56);
            this.btn_countWords.Name = "btn_countWords";
            this.btn_countWords.Size = new System.Drawing.Size(75, 23);
            this.btn_countWords.TabIndex = 10;
            this.btn_countWords.Text = "Count";
            this.btn_countWords.UseVisualStyleBackColor = true;
            this.btn_countWords.Click += new System.EventHandler(this.btn_countWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 584);
            this.Controls.Add(this.btn_countWords);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_sortWordList);
            this.Controls.Add(this.btn_createWordList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_chooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_createWordList;
        private System.Windows.Forms.Button btn_sortWordList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_countWords;
    }
}

