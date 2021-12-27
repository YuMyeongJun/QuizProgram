
namespace QuizProgram
{
    partial class QuizMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.Button();
            this.shootCombo = new System.Windows.Forms.ComboBox();
            this.shoot = new System.Windows.Forms.Label();
            this.passCombo = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.Label();
            this.defenceCombo = new System.Windows.Forms.ComboBox();
            this.defence = new System.Windows.Forms.Label();
            this.attackCombo = new System.Windows.Forms.ComboBox();
            this.attackLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtCalculation = new System.Windows.Forms.TextBox();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.dataAddBtn = new System.Windows.Forms.Button();
            this.calculationBtn = new System.Windows.Forms.Button();
            this.favoriteFoodBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart);
            this.groupBox1.Controls.Add(this.shootCombo);
            this.groupBox1.Controls.Add(this.shoot);
            this.groupBox1.Controls.Add(this.passCombo);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.defenceCombo);
            this.groupBox1.Controls.Add(this.defence);
            this.groupBox1.Controls.Add(this.attackCombo);
            this.groupBox1.Controls.Add(this.attackLabel);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.txtCalculation);
            this.groupBox1.Controls.Add(this.txtOne);
            this.groupBox1.Controls.Add(this.dataAddBtn);
            this.groupBox1.Controls.Add(this.calculationBtn);
            this.groupBox1.Controls.Add(this.favoriteFoodBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "컴퓨터소프트웨어학과 유명준";
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(29, 181);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(110, 23);
            this.chart.TabIndex = 4;
            this.chart.Text = "차트보기";
            this.chart.UseVisualStyleBackColor = true;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // shootCombo
            // 
            this.shootCombo.FormattingEnabled = true;
            this.shootCombo.Location = new System.Drawing.Point(574, 183);
            this.shootCombo.Name = "shootCombo";
            this.shootCombo.Size = new System.Drawing.Size(79, 20);
            this.shootCombo.TabIndex = 3;
            // 
            // shoot
            // 
            this.shoot.AutoSize = true;
            this.shoot.Location = new System.Drawing.Point(539, 186);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(17, 12);
            this.shoot.TabIndex = 2;
            this.shoot.Text = "슛";
            // 
            // passCombo
            // 
            this.passCombo.FormattingEnabled = true;
            this.passCombo.Location = new System.Drawing.Point(444, 183);
            this.passCombo.Name = "passCombo";
            this.passCombo.Size = new System.Drawing.Size(79, 20);
            this.passCombo.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(409, 186);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(29, 12);
            this.pass.TabIndex = 2;
            this.pass.Text = "패스";
            // 
            // defenceCombo
            // 
            this.defenceCombo.FormattingEnabled = true;
            this.defenceCombo.Location = new System.Drawing.Point(308, 183);
            this.defenceCombo.Name = "defenceCombo";
            this.defenceCombo.Size = new System.Drawing.Size(79, 20);
            this.defenceCombo.TabIndex = 3;
            // 
            // defence
            // 
            this.defence.AutoSize = true;
            this.defence.Location = new System.Drawing.Point(273, 186);
            this.defence.Name = "defence";
            this.defence.Size = new System.Drawing.Size(29, 12);
            this.defence.TabIndex = 2;
            this.defence.Text = "수비";
            // 
            // attackCombo
            // 
            this.attackCombo.FormattingEnabled = true;
            this.attackCombo.Location = new System.Drawing.Point(180, 184);
            this.attackCombo.Name = "attackCombo";
            this.attackCombo.Size = new System.Drawing.Size(79, 20);
            this.attackCombo.TabIndex = 3;
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(145, 187);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(29, 12);
            this.attackLabel.TabIndex = 2;
            this.attackLabel.Text = "공격";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(178, 147);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 2;
            this.name.Text = "이름";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(50, 114);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(40, 12);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(213, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(131, 111);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(174, 21);
            this.txtResult.TabIndex = 1;
            // 
            // txtCalculation
            // 
            this.txtCalculation.Location = new System.Drawing.Point(213, 74);
            this.txtCalculation.Name = "txtCalculation";
            this.txtCalculation.Size = new System.Drawing.Size(174, 21);
            this.txtCalculation.TabIndex = 1;
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(213, 35);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(174, 21);
            this.txtOne.TabIndex = 1;
            // 
            // dataAddBtn
            // 
            this.dataAddBtn.Location = new System.Drawing.Point(29, 141);
            this.dataAddBtn.Name = "dataAddBtn";
            this.dataAddBtn.Size = new System.Drawing.Size(143, 23);
            this.dataAddBtn.TabIndex = 0;
            this.dataAddBtn.Text = "데이터 추가";
            this.dataAddBtn.UseVisualStyleBackColor = true;
            // 
            // calculationBtn
            // 
            this.calculationBtn.Location = new System.Drawing.Point(29, 74);
            this.calculationBtn.Name = "calculationBtn";
            this.calculationBtn.Size = new System.Drawing.Size(144, 23);
            this.calculationBtn.TabIndex = 0;
            this.calculationBtn.Text = "계산식 입력";
            this.calculationBtn.UseVisualStyleBackColor = true;
            // 
            // favoriteFoodBtn
            // 
            this.favoriteFoodBtn.Location = new System.Drawing.Point(29, 35);
            this.favoriteFoodBtn.Name = "favoriteFoodBtn";
            this.favoriteFoodBtn.Size = new System.Drawing.Size(144, 23);
            this.favoriteFoodBtn.TabIndex = 0;
            this.favoriteFoodBtn.Text = "좋아하는 음식은?";
            this.favoriteFoodBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 225);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(660, 140);
            this.dataGridView.TabIndex = 4;
            // 
            // QuizMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 365);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuizMain";
            this.Text = "유명준 퀴즈";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox txtCalculation;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.Button dataAddBtn;
        private System.Windows.Forms.Button calculationBtn;
        private System.Windows.Forms.Button favoriteFoodBtn;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox attackCombo;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button chart;
        private System.Windows.Forms.ComboBox shootCombo;
        private System.Windows.Forms.Label shoot;
        private System.Windows.Forms.ComboBox passCombo;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.ComboBox defenceCombo;
        private System.Windows.Forms.Label defence;
    }
}

