﻿namespace pptVivo2007Addin
{
    partial class pptVivoRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public pptVivoRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.pptVivoTab = this.Factory.CreateRibbonTab();
            this.grpConnection = this.Factory.CreateRibbonGroup();
            this.grpPresentation = this.Factory.CreateRibbonGroup();
            this.btnLogin = this.Factory.CreateRibbonButton();
            this.btnAccount = this.Factory.CreateRibbonButton();
            this.btnStart = this.Factory.CreateRibbonButton();
            this.btnUpload = this.Factory.CreateRibbonButton();
            this.btnGetLink = this.Factory.CreateRibbonButton();
            this.btnQRCode = this.Factory.CreateRibbonButton();
            this.btnQuestion = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.pptVivoTab.SuspendLayout();
            this.grpConnection.SuspendLayout();
            this.grpPresentation.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // pptVivoTab
            // 
            this.pptVivoTab.Groups.Add(this.grpConnection);
            this.pptVivoTab.Groups.Add(this.grpPresentation);
            this.pptVivoTab.Label = "pptVivo!";
            this.pptVivoTab.Name = "pptVivoTab";
            // 
            // grpConnection
            // 
            this.grpConnection.Items.Add(this.btnLogin);
            this.grpConnection.Items.Add(this.btnAccount);
            this.grpConnection.Label = "Account";
            this.grpConnection.Name = "grpConnection";
            // 
            // grpPresentation
            // 
            this.grpPresentation.Items.Add(this.btnStart);
            this.grpPresentation.Items.Add(this.btnUpload);
            this.grpPresentation.Items.Add(this.btnGetLink);
            this.grpPresentation.Items.Add(this.btnQRCode);
            this.grpPresentation.Items.Add(this.btnQuestion);
            this.grpPresentation.Label = "Presentation";
            this.grpPresentation.Name = "grpPresentation";
            // 
            // btnLogin
            // 
            this.btnLogin.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLogin.Description = "Login to pptVivo!";
            this.btnLogin.Image = global::pptVivo2007Addin.Properties.Resources.Login32;
            this.btnLogin.Label = "Login to pptVivo!";
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowImage = true;
            this.btnLogin.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLogin_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAccount.Description = "Go to pptVivo! website";
            this.btnAccount.Image = global::pptVivo2007Addin.Properties.Resources.account32;
            this.btnAccount.Label = "Go to website";
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.ShowImage = true;
            this.btnAccount.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAccount_Click);
            // 
            // btnStart
            // 
            this.btnStart.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnStart.Description = "Create exposition";
            this.btnStart.Image = global::pptVivo2007Addin.Properties.Resources.start32;
            this.btnStart.Label = "Create Exposition";
            this.btnStart.Name = "btnStart";
            this.btnStart.ShowImage = true;
            // 
            // btnUpload
            // 
            this.btnUpload.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnUpload.Description = "Add presentation to pptVivo! account";
            this.btnUpload.Image = global::pptVivo2007Addin.Properties.Resources.upload32;
            this.btnUpload.Label = "Upload presentation";
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.ShowImage = true;
            // 
            // btnGetLink
            // 
            this.btnGetLink.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnGetLink.Description = "Generate short URL";
            this.btnGetLink.Image = global::pptVivo2007Addin.Properties.Resources.link32;
            this.btnGetLink.Label = "Get short URL";
            this.btnGetLink.Name = "btnGetLink";
            this.btnGetLink.ShowImage = true;
            // 
            // btnQRCode
            // 
            this.btnQRCode.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnQRCode.Description = "Generate QR Code";
            this.btnQRCode.Image = global::pptVivo2007Addin.Properties.Resources.qrcode32;
            this.btnQRCode.Label = "Get QR code";
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.ShowImage = true;
            // 
            // btnQuestion
            // 
            this.btnQuestion.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnQuestion.Description = "Show audience questions";
            this.btnQuestion.Image = global::pptVivo2007Addin.Properties.Resources.questions32;
            this.btnQuestion.Label = "Audience questions";
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.ShowImage = true;
            // 
            // pptVivoRibbon
            // 
            this.Name = "pptVivoRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.pptVivoTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.pptVivoRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.pptVivoTab.ResumeLayout(false);
            this.pptVivoTab.PerformLayout();
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpPresentation.ResumeLayout(false);
            this.grpPresentation.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab pptVivoTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpConnection;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogin;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAccount;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpPresentation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnUpload;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGetLink;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnQRCode;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnQuestion;
    }

    partial class ThisRibbonCollection
    {
        internal pptVivoRibbon pptVivoRibbon
        {
            get { return this.GetRibbon<pptVivoRibbon>(); }
        }
    }
}
