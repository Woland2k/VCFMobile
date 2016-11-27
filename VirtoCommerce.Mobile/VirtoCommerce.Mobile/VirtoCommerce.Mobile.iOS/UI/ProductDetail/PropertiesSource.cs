using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Themes;

namespace VirtoCommerce.Mobile.iOS.UI.ProductDetail
{
    public class PropertiesSource : UITableViewSource
    {
        public List<KeyValuePair<string, string>> CellsData { set; get; }
        public PropertiesSource(List<KeyValuePair<string, string>> cells)
        {
            CellsData = cells;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.RegisterClassForCellReuse(typeof(PropertyCell),PropertyCell.CellId);
            var cell = tableView.DequeueReusableCell(PropertyCell.CellId) as PropertyCell;

            var cellData = CellsData[indexPath.Row];
            cell.UpdateCell(cellData);
            //
           /* cell.TextLabel.TextAlignment = UITextAlignment.Right;
            cell.TextLabel.Text = cellData.Key;
            cell.TextLabel.Lines = 0;
            cell.TextLabel.LineBreakMode = UILineBreakMode.WordWrap;
            cell.TextLabel.TextColor = UI.Consts.ColorMain;
            cell.TextLabel.SizeToFit();
            //
            cell.DetailTextLabel.Text = cellData.Value;
            cell.DetailTextLabel.TextAlignment = UITextAlignment.Left;
            cell.DetailTextLabel.Lines = 0;
            cell.DetailTextLabel.LineBreakMode = UILineBreakMode.WordWrap;
            cell.DetailTextLabel.SizeToFit();*/
            //
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            cell.BackgroundColor = Consts.ColorMainBg;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return CellsData.Count;
        }
    }
}