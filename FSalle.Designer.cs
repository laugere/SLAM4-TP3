namespace MusicAtoutV1
{
    partial class FSalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSalle));
            this.bnSalle = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.dgSalle = new System.Windows.Forms.DataGridView();
            this.idBatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capaciteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superficieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bATIMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEOEUVREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSalle = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnSalle)).BeginInit();
            this.bnSalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalle)).BeginInit();
            this.SuspendLayout();
            // 
            // bnSalle
            // 
            this.bnSalle.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnSalle.BindingSource = this.bsSalle;
            this.bnSalle.CountItem = this.bindingNavigatorCountItem;
            this.bnSalle.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnSalle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnSalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnSalle.Location = new System.Drawing.Point(0, 0);
            this.bnSalle.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnSalle.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnSalle.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnSalle.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnSalle.Name = "bnSalle";
            this.bnSalle.PositionItem = this.bindingNavigatorPositionItem;
            this.bnSalle.Size = new System.Drawing.Size(800, 27);
            this.bnSalle.TabIndex = 0;
            this.bnSalle.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // dgSalle
            // 
            this.dgSalle.AutoGenerateColumns = false;
            this.dgSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBatiDataGridViewTextBoxColumn,
            this.numSalleDataGridViewTextBoxColumn,
            this.nomSalleDataGridViewTextBoxColumn,
            this.capaciteDataGridViewTextBoxColumn,
            this.superficieDataGridViewTextBoxColumn,
            this.bATIMENTDataGridViewTextBoxColumn,
            this.tYPEOEUVREDataGridViewTextBoxColumn});
            this.dgSalle.DataSource = this.bsSalle;
            this.dgSalle.Location = new System.Drawing.Point(12, 30);
            this.dgSalle.Name = "dgSalle";
            this.dgSalle.RowHeadersWidth = 51;
            this.dgSalle.RowTemplate.Height = 24;
            this.dgSalle.Size = new System.Drawing.Size(776, 408);
            this.dgSalle.TabIndex = 1;
            // 
            // idBatiDataGridViewTextBoxColumn
            // 
            this.idBatiDataGridViewTextBoxColumn.DataPropertyName = "idBati";
            this.idBatiDataGridViewTextBoxColumn.HeaderText = "idBati";
            this.idBatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idBatiDataGridViewTextBoxColumn.Name = "idBatiDataGridViewTextBoxColumn";
            this.idBatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // numSalleDataGridViewTextBoxColumn
            // 
            this.numSalleDataGridViewTextBoxColumn.DataPropertyName = "numSalle";
            this.numSalleDataGridViewTextBoxColumn.HeaderText = "numSalle";
            this.numSalleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numSalleDataGridViewTextBoxColumn.Name = "numSalleDataGridViewTextBoxColumn";
            this.numSalleDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomSalleDataGridViewTextBoxColumn
            // 
            this.nomSalleDataGridViewTextBoxColumn.DataPropertyName = "nomSalle";
            this.nomSalleDataGridViewTextBoxColumn.HeaderText = "nomSalle";
            this.nomSalleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomSalleDataGridViewTextBoxColumn.Name = "nomSalleDataGridViewTextBoxColumn";
            this.nomSalleDataGridViewTextBoxColumn.Width = 125;
            // 
            // capaciteDataGridViewTextBoxColumn
            // 
            this.capaciteDataGridViewTextBoxColumn.DataPropertyName = "capacite";
            this.capaciteDataGridViewTextBoxColumn.HeaderText = "capacite";
            this.capaciteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capaciteDataGridViewTextBoxColumn.Name = "capaciteDataGridViewTextBoxColumn";
            this.capaciteDataGridViewTextBoxColumn.Width = 125;
            // 
            // superficieDataGridViewTextBoxColumn
            // 
            this.superficieDataGridViewTextBoxColumn.DataPropertyName = "superficie";
            this.superficieDataGridViewTextBoxColumn.HeaderText = "superficie";
            this.superficieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.superficieDataGridViewTextBoxColumn.Name = "superficieDataGridViewTextBoxColumn";
            this.superficieDataGridViewTextBoxColumn.Width = 125;
            // 
            // bATIMENTDataGridViewTextBoxColumn
            // 
            this.bATIMENTDataGridViewTextBoxColumn.DataPropertyName = "BATIMENT";
            this.bATIMENTDataGridViewTextBoxColumn.HeaderText = "BATIMENT";
            this.bATIMENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bATIMENTDataGridViewTextBoxColumn.Name = "bATIMENTDataGridViewTextBoxColumn";
            this.bATIMENTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tYPEOEUVREDataGridViewTextBoxColumn
            // 
            this.tYPEOEUVREDataGridViewTextBoxColumn.DataPropertyName = "TYPEOEUVRE";
            this.tYPEOEUVREDataGridViewTextBoxColumn.HeaderText = "TYPEOEUVRE";
            this.tYPEOEUVREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tYPEOEUVREDataGridViewTextBoxColumn.Name = "tYPEOEUVREDataGridViewTextBoxColumn";
            this.tYPEOEUVREDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsSalle
            // 
            this.bsSalle.DataSource = typeof(MusicAtoutV1.SALLE);
            // 
            // FSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSalle);
            this.Controls.Add(this.bnSalle);
            this.Name = "FSalle";
            this.Text = "FSalle";
            this.Load += new System.EventHandler(this.FSalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnSalle)).EndInit();
            this.bnSalle.ResumeLayout(false);
            this.bnSalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnSalle;
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
        private System.Windows.Forms.BindingSource bsSalle;
        private System.Windows.Forms.DataGridView dgSalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capaciteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn superficieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bATIMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEOEUVREDataGridViewTextBoxColumn;
    }
}