namespace evosim
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.Simulation = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.entities = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.NumericUpDown();
            this.GenTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.StartUnits = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitsReward = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.IdleUsage = new System.Windows.Forms.NumericUpDown();
            this.Continue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MoveCost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxSatisfaction = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.SimSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.MutationChance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.entities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.units)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdleUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSatisfaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationChance)).BeginInit();
            this.SuspendLayout();
            // 
            // Simulation
            // 
            this.Simulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Simulation.Location = new System.Drawing.Point(48, 76);
            this.Simulation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Simulation.Name = "Simulation";
            this.Simulation.Size = new System.Drawing.Size(400, 363);
            this.Simulation.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(48, 35);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(104, 33);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // entities
            // 
            this.entities.Location = new System.Drawing.Point(158, 25);
            this.entities.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.entities.Name = "entities";
            this.entities.Size = new System.Drawing.Size(70, 25);
            this.entities.TabIndex = 2;
            this.entities.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Units";
            // 
            // units
            // 
            this.units.Location = new System.Drawing.Point(238, 25);
            this.units.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.units.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(70, 25);
            this.units.TabIndex = 4;
            this.units.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GenTimer
            // 
            this.GenTimer.Tick += new System.EventHandler(this.GenTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start units";
            // 
            // StartUnits
            // 
            this.StartUnits.Location = new System.Drawing.Point(317, 25);
            this.StartUnits.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.StartUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartUnits.Name = "StartUnits";
            this.StartUnits.Size = new System.Drawing.Size(70, 25);
            this.StartUnits.TabIndex = 6;
            this.StartUnits.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unit reward";
            // 
            // UnitsReward
            // 
            this.UnitsReward.Location = new System.Drawing.Point(396, 25);
            this.UnitsReward.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.UnitsReward.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UnitsReward.Name = "UnitsReward";
            this.UnitsReward.Size = new System.Drawing.Size(70, 25);
            this.UnitsReward.TabIndex = 8;
            this.UnitsReward.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Idle Unit Usage";
            // 
            // IdleUsage
            // 
            this.IdleUsage.DecimalPlaces = 2;
            this.IdleUsage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.IdleUsage.Location = new System.Drawing.Point(454, 76);
            this.IdleUsage.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.IdleUsage.Name = "IdleUsage";
            this.IdleUsage.Size = new System.Drawing.Size(70, 25);
            this.IdleUsage.TabIndex = 10;
            this.IdleUsage.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(454, 395);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(96, 44);
            this.Continue.TabIndex = 12;
            this.Continue.Text = "Continue (Next gen)";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Move Cost Coeff";
            // 
            // MoveCost
            // 
            this.MoveCost.DecimalPlaces = 2;
            this.MoveCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MoveCost.Location = new System.Drawing.Point(454, 135);
            this.MoveCost.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MoveCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MoveCost.Name = "MoveCost";
            this.MoveCost.Size = new System.Drawing.Size(70, 25);
            this.MoveCost.TabIndex = 13;
            this.MoveCost.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Max Satisfaction";
            // 
            // MaxSatisfaction
            // 
            this.MaxSatisfaction.Location = new System.Drawing.Point(457, 193);
            this.MaxSatisfaction.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MaxSatisfaction.Name = "MaxSatisfaction";
            this.MaxSatisfaction.Size = new System.Drawing.Size(70, 25);
            this.MaxSatisfaction.TabIndex = 15;
            this.MaxSatisfaction.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Simulation speed";
            // 
            // SimSpeed
            // 
            this.SimSpeed.DecimalPlaces = 2;
            this.SimSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SimSpeed.Location = new System.Drawing.Point(460, 252);
            this.SimSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SimSpeed.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.SimSpeed.Name = "SimSpeed";
            this.SimSpeed.Size = new System.Drawing.Size(70, 25);
            this.SimSpeed.TabIndex = 17;
            this.SimSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mutation Chance";
            // 
            // MutationChance
            // 
            this.MutationChance.DecimalPlaces = 2;
            this.MutationChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MutationChance.Location = new System.Drawing.Point(463, 312);
            this.MutationChance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MutationChance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.MutationChance.Name = "MutationChance";
            this.MutationChance.Size = new System.Drawing.Size(70, 25);
            this.MutationChance.TabIndex = 19;
            this.MutationChance.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 451);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MutationChance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SimSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxSatisfaction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MoveCost);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdleUsage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UnitsReward);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.units);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entities);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Simulation);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.ShowIcon = false;
            this.Text = "Evolution Simulation";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.units)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdleUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSatisfaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationChance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Simulation;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown entities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown units;
        private System.Windows.Forms.Timer GenTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StartUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown UnitsReward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdleUsage;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MoveCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MaxSatisfaction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown SimSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown MutationChance;
    }
}

