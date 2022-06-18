using System.Reflection;

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

				/*foreach (ComboBox comboBox in groupBox.Controls.OfType<ComboBox>())
					comboBox.SelectedIndex = -1;*/

				foreach (CheckedListBox checkBox in groupBox.Controls.OfType<CheckedListBox>())
					while (checkBox.CheckedIndices.Count > 0)
						checkBox.SetItemChecked(checkBox.CheckedIndices[0], false);
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
				return null;
			}
		}

		internal static void SelectRowById(int? selectedRowIndex, DataGridView dataGridView, Action<object, DataGridViewCellEventArgs> action)
		{
			if (selectedRowIndex != null)
			{
				DataGridViewRow row = dataGridView.Rows
					.Cast<DataGridViewRow>()
					.Where(s => s.Cells[0].Value.ToString().Equals(selectedRowIndex.ToString()))
					.First();

				dataGridView.Rows[row.Index].Selected = true;
				action.Invoke(dataGridView, new DataGridViewCellEventArgs(0, (int)selectedRowIndex));
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
			PropertyInfo propertyInfo = list[0].GetType().GetProperty(property);

			if (!list.OrderBy(s => propertyInfo.GetValue(s)).SequenceEqual(list))
				list = list.OrderBy(s => propertyInfo.GetValue(s)).ToList();
			else
				list = list.OrderByDescending(s => propertyInfo.GetValue(s)).ToList();

			return list;
		}

		internal static List<dynamic>? GetObjectByAttribute(string? property, dynamic? searchParam, List<dynamic> list)
		{
			PropertyInfo propertyInfo = list[0].GetType().GetProperty(property);

			return list.Where(s => propertyInfo.GetValue(s) == searchParam).ToList();
		}

		internal static void HandleComboBoxes(CheckBox checkBox, Control control)
		{
			IEnumerable<Control> controls = GetControls(control, typeof(ComboBox));
			ComboBox? comboBox = controls.OfType<ComboBox>()
				.SingleOrDefault(s => s.Name == checkBox.Tag.ToString());

			if (checkBox.Checked)
				comboBox.Enabled = true;
			else
				comboBox.Enabled = false;


			IEnumerable<Control> GetControls(Control control, Type type)
			{
				var controls = control.Controls.OfType<Control>();
				return controls.SelectMany(s => GetControls(s, type))
					.Concat(controls)
					.Where(c => c.GetType() == type);
			}
		}
	}
}
