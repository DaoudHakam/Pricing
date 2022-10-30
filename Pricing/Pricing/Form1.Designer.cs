
namespace Pricing
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_S = new System.Windows.Forms.TextBox();
            this.tb_K = new System.Windows.Forms.TextBox();
            this.tb_Sigma = new System.Windows.Forms.TextBox();
            this.tb_T = new System.Windows.Forms.TextBox();
            this.tb_r = new System.Windows.Forms.TextBox();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_binomial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_steps = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_black = new System.Windows.Forms.TextBox();
            this.tb_Put_black = new System.Windows.Forms.TextBox();
            this.tb_call_Binomial = new System.Windows.Forms.TextBox();
            this.tb_deltaCall_black = new System.Windows.Forms.TextBox();
            this.tb_deltaPut_black = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_put_binomial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_gamma = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_theta_call = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_theta_put = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_vega_call = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_rho_call = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_rho_put = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_M = new System.Windows.Forms.Button();
            this.tb_monte_call = new System.Windows.Forms.TextBox();
            this.tbn_monte_put = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_paths = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pricing of European Option";
            // 
            // tb_S
            // 
            this.tb_S.Location = new System.Drawing.Point(161, 111);
            this.tb_S.Name = "tb_S";
            this.tb_S.Size = new System.Drawing.Size(165, 22);
            this.tb_S.TabIndex = 1;
            // 
            // tb_K
            // 
            this.tb_K.Location = new System.Drawing.Point(350, 111);
            this.tb_K.Name = "tb_K";
            this.tb_K.Size = new System.Drawing.Size(165, 22);
            this.tb_K.TabIndex = 2;
            // 
            // tb_Sigma
            // 
            this.tb_Sigma.Location = new System.Drawing.Point(731, 111);
            this.tb_Sigma.Name = "tb_Sigma";
            this.tb_Sigma.Size = new System.Drawing.Size(165, 22);
            this.tb_Sigma.TabIndex = 4;
            // 
            // tb_T
            // 
            this.tb_T.Location = new System.Drawing.Point(542, 111);
            this.tb_T.Name = "tb_T";
            this.tb_T.Size = new System.Drawing.Size(165, 22);
            this.tb_T.TabIndex = 3;
            // 
            // tb_r
            // 
            this.tb_r.Location = new System.Drawing.Point(925, 111);
            this.tb_r.Name = "tb_r";
            this.tb_r.Size = new System.Drawing.Size(165, 22);
            this.tb_r.TabIndex = 5;
            // 
            // btn_b
            // 
            this.btn_b.Location = new System.Drawing.Point(461, 265);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(120, 42);
            this.btn_b.TabIndex = 8;
            this.btn_b.Text = "BlackSholes Model";
            this.btn_b.UseVisualStyleBackColor = true;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            // 
            // btn_binomial
            // 
            this.btn_binomial.Location = new System.Drawing.Point(782, 265);
            this.btn_binomial.Name = "btn_binomial";
            this.btn_binomial.Size = new System.Drawing.Size(120, 42);
            this.btn_binomial.TabIndex = 10;
            this.btn_binomial.Text = "Binomial Model";
            this.btn_binomial.UseVisualStyleBackColor = true;
            this.btn_binomial.Click += new System.EventHandler(this.btn_binomial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Underlying\'s Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Strike";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Maturity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(786, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Volatility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(964, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Risk-Free Rate";
            // 
            // tb_steps
            // 
            this.tb_steps.Location = new System.Drawing.Point(928, 285);
            this.tb_steps.Name = "tb_steps";
            this.tb_steps.Size = new System.Drawing.Size(74, 22);
            this.tb_steps.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(942, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "steps";
            // 
            // tb_black
            // 
            this.tb_black.Location = new System.Drawing.Point(461, 345);
            this.tb_black.Name = "tb_black";
            this.tb_black.Size = new System.Drawing.Size(147, 22);
            this.tb_black.TabIndex = 22;
            // 
            // tb_Put_black
            // 
            this.tb_Put_black.Location = new System.Drawing.Point(461, 399);
            this.tb_Put_black.Name = "tb_Put_black";
            this.tb_Put_black.Size = new System.Drawing.Size(147, 22);
            this.tb_Put_black.TabIndex = 23;
            // 
            // tb_call_Binomial
            // 
            this.tb_call_Binomial.Location = new System.Drawing.Point(772, 340);
            this.tb_call_Binomial.Name = "tb_call_Binomial";
            this.tb_call_Binomial.Size = new System.Drawing.Size(147, 22);
            this.tb_call_Binomial.TabIndex = 24;
            // 
            // tb_deltaCall_black
            // 
            this.tb_deltaCall_black.Location = new System.Drawing.Point(157, 265);
            this.tb_deltaCall_black.Name = "tb_deltaCall_black";
            this.tb_deltaCall_black.Size = new System.Drawing.Size(147, 22);
            this.tb_deltaCall_black.TabIndex = 25;
            // 
            // tb_deltaPut_black
            // 
            this.tb_deltaPut_black.Location = new System.Drawing.Point(157, 293);
            this.tb_deltaPut_black.Name = "tb_deltaPut_black";
            this.tb_deltaPut_black.Size = new System.Drawing.Size(147, 22);
            this.tb_deltaPut_black.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Call";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Call\'s Delta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Put";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Put\'s Delta";
            // 
            // tb_put_binomial
            // 
            this.tb_put_binomial.Location = new System.Drawing.Point(772, 399);
            this.tb_put_binomial.Name = "tb_put_binomial";
            this.tb_put_binomial.Size = new System.Drawing.Size(147, 22);
            this.tb_put_binomial.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Gamma";
            // 
            // tb_gamma
            // 
            this.tb_gamma.Location = new System.Drawing.Point(157, 321);
            this.tb_gamma.Name = "tb_gamma";
            this.tb_gamma.Size = new System.Drawing.Size(147, 22);
            this.tb_gamma.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(61, 352);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Call\'s Theta";
            // 
            // tb_theta_call
            // 
            this.tb_theta_call.Location = new System.Drawing.Point(157, 349);
            this.tb_theta_call.Name = "tb_theta_call";
            this.tb_theta_call.Size = new System.Drawing.Size(147, 22);
            this.tb_theta_call.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "Call\'s Theta";
            // 
            // tb_theta_put
            // 
            this.tb_theta_put.Location = new System.Drawing.Point(157, 377);
            this.tb_theta_put.Name = "tb_theta_put";
            this.tb_theta_put.Size = new System.Drawing.Size(147, 22);
            this.tb_theta_put.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(61, 410);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 17);
            this.label18.TabIndex = 42;
            this.label18.Text = "Vega";
            // 
            // tb_vega_call
            // 
            this.tb_vega_call.Location = new System.Drawing.Point(157, 405);
            this.tb_vega_call.Name = "tb_vega_call";
            this.tb_vega_call.Size = new System.Drawing.Size(147, 22);
            this.tb_vega_call.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 436);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 17);
            this.label20.TabIndex = 46;
            this.label20.Text = "Call\'s Rho";
            // 
            // tb_rho_call
            // 
            this.tb_rho_call.Location = new System.Drawing.Point(157, 433);
            this.tb_rho_call.Name = "tb_rho_call";
            this.tb_rho_call.Size = new System.Drawing.Size(147, 22);
            this.tb_rho_call.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(61, 464);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 17);
            this.label21.TabIndex = 48;
            this.label21.Text = "Call\'s Rho";
            // 
            // tb_rho_put
            // 
            this.tb_rho_put.Location = new System.Drawing.Point(157, 461);
            this.tb_rho_put.Name = "tb_rho_put";
            this.tb_rho_put.Size = new System.Drawing.Size(147, 22);
            this.tb_rho_put.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Option Greeks";
            // 
            // btn_M
            // 
            this.btn_M.Location = new System.Drawing.Point(1076, 265);
            this.btn_M.Name = "btn_M";
            this.btn_M.Size = new System.Drawing.Size(120, 42);
            this.btn_M.TabIndex = 50;
            this.btn_M.Text = "MonteCarlo ";
            this.btn_M.UseVisualStyleBackColor = true;
            this.btn_M.Click += new System.EventHandler(this.btn_M_Click_1);
            // 
            // tb_monte_call
            // 
            this.tb_monte_call.Location = new System.Drawing.Point(1061, 340);
            this.tb_monte_call.Name = "tb_monte_call";
            this.tb_monte_call.Size = new System.Drawing.Size(147, 22);
            this.tb_monte_call.TabIndex = 51;
            // 
            // tbn_monte_put
            // 
            this.tbn_monte_put.Location = new System.Drawing.Point(1061, 399);
            this.tbn_monte_put.Name = "tbn_monte_put";
            this.tbn_monte_put.Size = new System.Drawing.Size(147, 22);
            this.tbn_monte_put.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1252, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Paths";
            // 
            // tb_paths
            // 
            this.tb_paths.Location = new System.Drawing.Point(1238, 285);
            this.tb_paths.Name = "tb_paths";
            this.tb_paths.Size = new System.Drawing.Size(74, 22);
            this.tb_paths.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 538);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_paths);
            this.Controls.Add(this.tbn_monte_put);
            this.Controls.Add(this.tb_monte_call);
            this.Controls.Add(this.btn_M);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tb_rho_put);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_rho_call);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tb_vega_call);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_theta_put);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_theta_call);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_gamma);
            this.Controls.Add(this.tb_put_binomial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_deltaPut_black);
            this.Controls.Add(this.tb_deltaCall_black);
            this.Controls.Add(this.tb_call_Binomial);
            this.Controls.Add(this.tb_Put_black);
            this.Controls.Add(this.tb_black);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_steps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_binomial);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.tb_r);
            this.Controls.Add(this.tb_Sigma);
            this.Controls.Add(this.tb_T);
            this.Controls.Add(this.tb_K);
            this.Controls.Add(this.tb_S);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_S;
        private System.Windows.Forms.TextBox tb_K;
        private System.Windows.Forms.TextBox tb_Sigma;
        private System.Windows.Forms.TextBox tb_T;
        private System.Windows.Forms.TextBox tb_r;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_binomial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_steps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_black;
        private System.Windows.Forms.TextBox tb_Put_black;
        private System.Windows.Forms.TextBox tb_call_Binomial;
        private System.Windows.Forms.TextBox tb_deltaCall_black;
        private System.Windows.Forms.TextBox tb_deltaPut_black;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_put_binomial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_gamma;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_theta_call;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_theta_put;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_vega_call;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_rho_call;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_rho_put;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_M;
        private System.Windows.Forms.TextBox tb_monte_call;
        private System.Windows.Forms.TextBox tbn_monte_put;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_paths;
    }
}

