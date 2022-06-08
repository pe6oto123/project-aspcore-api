namespace project_gui.DataModels._uitl
{
	internal class HelperFuncs
	{
		internal static void ClearFields(List<GroupBox> groupBoxList)
		{
			foreach (GroupBox groupBox in groupBoxList)
			{
				foreach (TextBox textBox in groupBox.Controls.OfType<TextBox>())
					textBox.Text = null;

				foreach (NumericUpDown numUpDown in groupBox.Controls.OfType<NumericUpDown>())
					numUpDown.Value = 0;

				foreach (ComboBox comboBox in groupBox.Controls.OfType<ComboBox>())
					if (comboBox.Items.Count > 0)
						comboBox.SelectedIndex = 0;

				foreach (CheckBox checkBox in groupBox.Controls.OfType<CheckBox>())
					checkBox.Checked = false;
			}
		}

		internal static int? GetSelectedRowId(DataGridView dataGrid)
		{
			try
			{
				int selectedRowIndex = dataGrid.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = dataGrid.Rows[selectedRowIndex];
				return (int)selectedRow.Cells[0].Value;
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		internal static void DisplaySearchList(List<dynamic>? searchList, DataGridView dataGridView, CurrencyManager currencyManager)
		{
			if (searchList == null || !searchList.Any())
			{
				MessageBox.Show("No matches.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			List<int> searchListIds = new();
			foreach (var row in searchList)
				searchListIds.Add(row.Id);

			dataGridView.Rows.OfType<DataGridViewRow>().ToList().ForEach(col => col.Visible = true);

			currencyManager.SuspendBinding();

			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				if (!searchListIds.Contains((int)row.Cells[0].Value))
					row.Visible = false;
			}
			currencyManager.ResumeBinding();

			dataGridView.ClearSelection();
		}

		internal static string RequiredFieldsError(dynamic response)
		{
			string message = "";
			foreach (var errors in response.errors)
				foreach (var error in errors)
					foreach (var subError in error)
						message += subError.ToString() + "\n";

			return message;
		}

		internal static List<dynamic>? SortTable(string property, List<dynamic>? list)
		{
			System.Reflection.PropertyInfo propertyInfo = list[0].GetType().GetProperty(property);

			if (!list.OrderBy(s => propertyInfo.GetValue(s)).SequenceEqual(list))
				list = list.OrderBy(s => propertyInfo.GetValue(s)).ToList();
			else
				list = list.OrderByDescending(s => propertyInfo.GetValue(s)).ToList();

			return list;
		}
	}
}
