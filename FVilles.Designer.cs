namespace MusicAtoutV1
{
    partial class FVilles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVilles));
            this.dgVille = new System.Windows.Forms.DataGridView();
            this.idVilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVille = new System.Windows.Forms.BindingSource(this.components);
            this.bnVille = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnVille)).BeginInit();
            this.bnVille.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVille
            // 
            this.dgVille.AutoGenerateColumns = false;
            this.dgVille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVilleDataGridViewTextBoxColumn,
            this.nomVilleDataGridViewTextBoxColumn,
            this.departementDataGridViewTextBoxColumn});
            this.dgVille.DataSource = this.bsVille;
            this.dgVille.Location = new System.Drawing.Point(12, 30);
            this.dgVille.Name = "dgVille";
            this.dgVille.RowHeadersWidth = 51;
            this.dgVille.RowTemplate.Height = 24;
            this.dgVille.Size = new System.Drawing.Size(776, 408);
            this.dgVille.TabIndex = 0;
            // 
            // idVilleDataGridViewTextBoxColumn
            // 
            this.idVilleDataGridViewTextBoxColumn.DataPropertyName = "idVille";
            this.idVilleDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.idVilleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVilleDataGridViewTextBoxColumn.Name = "idVilleDataGridViewTextBoxColumn";
            this.idVilleDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomVilleDataGridViewTextBoxColumn
            // 
            this.nomVilleDataGridViewTextBoxColumn.DataPropertyName = "nomVille";
            this.nomVilleDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomVilleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomVilleDataGridViewTextBoxColumn.Name = "nomVilleDataGridViewTextBoxColumn";
            this.nomVilleDataGridViewTextBoxColumn.Width = 125;
            // 
            // departementDataGridViewTextBoxColumn
            // 
            this.departementDataGridViewTextBoxColumn.DataPropertyName = "departement";
            this.departementDataGridViewTextBoxColumn.HeaderText = "Département";
            this.departementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departementDataGridViewTextBoxColumn.Name = "departementDataGridViewTextBoxColumn";
            this.departementDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsVille
            // 
            this.bsVille.DataSource = typeof(MusicAtoutV1.VILLE);
            // 
            // bnVille
            // 
            this.bnVille.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnVille.CountItem = this.bindingNavigatorCountItem;
            this.bnVille.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnVille.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnVille.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnVille.Location = new System.Drawing.Point(0, 0);
            this.bnVille.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnVille.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnVille.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnVille.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnVille.Name = "bnVille";
            this.bnVille.PositionItem = this.bindingNavigatorPositionItem;
            this.bnVille.Size = new System.Drawing.Size(800, 27);
            this.bnVille.TabIndex = 1;
            this.bnVille.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // FVilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnVille);
            this.Controls.Add(this.dgVille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FVilles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Villes";
            this.Load += new System.EventHandler(this.FVilles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnVille)).EndInit();
            this.bnVille.ResumeLayout(false);
            this.bnVille.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVille;
        private System.Windows.Forms.BindingSource bsVille;
        private System.Windows.Forms.BindingNavigator bnVille;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departementDataGridViewTextBoxColumn;
    }
}