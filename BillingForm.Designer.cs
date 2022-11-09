namespace RestaurantBillingSystem_RBS
{
    partial class BillingForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BillingDataSet = new RestaurantBillingSystem_RBS.BillingDataSet();
            this.BillingTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillingTableTableAdapter = new RestaurantBillingSystem_RBS.BillingDataSetTableAdapters.BillingTableTableAdapter();
            this.OrderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderTableTableAdapter = new RestaurantBillingSystem_RBS.BillingDataSetTableAdapters.OrderTableTableAdapter();
            this.CompanyInfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyInfoTableTableAdapter = new RestaurantBillingSystem_RBS.BillingDataSetTableAdapters.CompanyInfoTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BillingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyInfoTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Billing";
            reportDataSource1.Value = this.BillingTableBindingSource;
            reportDataSource2.Name = "OrderDataSet";
            reportDataSource2.Value = this.OrderTableBindingSource;
            reportDataSource3.Name = "CompanyDataSet";
            reportDataSource3.Value = this.CompanyInfoTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RestaurantBillingSystem_RBS.Billing.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(709, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BillingDataSet
            // 
            this.BillingDataSet.DataSetName = "BillingDataSet";
            this.BillingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillingTableBindingSource
            // 
            this.BillingTableBindingSource.DataMember = "BillingTable";
            this.BillingTableBindingSource.DataSource = this.BillingDataSet;
            // 
            // BillingTableTableAdapter
            // 
            this.BillingTableTableAdapter.ClearBeforeFill = true;
            // 
            // OrderTableBindingSource
            // 
            this.OrderTableBindingSource.DataMember = "OrderTable";
            this.OrderTableBindingSource.DataSource = this.BillingDataSet;
            // 
            // OrderTableTableAdapter
            // 
            this.OrderTableTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyInfoTableBindingSource
            // 
            this.CompanyInfoTableBindingSource.DataMember = "CompanyInfoTable";
            this.CompanyInfoTableBindingSource.DataSource = this.BillingDataSet;
            // 
            // CompanyInfoTableTableAdapter
            // 
            this.CompanyInfoTableTableAdapter.ClearBeforeFill = true;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Billing System";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyInfoTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BillingTableBindingSource;
        private BillingDataSet BillingDataSet;
        private System.Windows.Forms.BindingSource OrderTableBindingSource;
        private System.Windows.Forms.BindingSource CompanyInfoTableBindingSource;
        private BillingDataSetTableAdapters.BillingTableTableAdapter BillingTableTableAdapter;
        private BillingDataSetTableAdapters.OrderTableTableAdapter OrderTableTableAdapter;
        private BillingDataSetTableAdapters.CompanyInfoTableTableAdapter CompanyInfoTableTableAdapter;
    }
}