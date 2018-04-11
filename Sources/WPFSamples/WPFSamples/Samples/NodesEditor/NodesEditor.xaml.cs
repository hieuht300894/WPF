﻿using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace WPFSamples.Samples.NodesEditor
{
    [Category("Highlights")]
    [Description("A completely functional WPF/MVVM Node Diagram Editor supporting draggable nodes, grid snapping, creation/removal of nodes and connections, renaming of nodes, and customizable surface size.\r\nIt demonstrates the use of WPF's DataBinding and visual customization capabilities.\r\nThe actual data is completely decoupled from the UI and therefore it's very suitable for serialization/storage.")]
    [RelatedUrl("http://stackoverflow.com/questions/15579069/graph-nodes-coordinates-evaluation", "Graph nodes coordinates evaluation")]
    public partial class NodesEditor : SampleWindow
    {
        public List<Node> Nodes { get; set; }
        public List<Connector> Connectors { get; set; }

        public NodesEditor()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Thumb_Drag(object sender, DragDeltaEventArgs e)
        {
            var thumb = sender as Thumb;
            if (thumb == null)
                return;

            var node = thumb.DataContext as Node;
            if (node == null)
                return;

            node.X += e.HorizontalChange;
            node.Y += e.VerticalChange;
        }

        private void ListBox_PreviewMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var listbox = sender as ListBox;

            if (listbox == null)
                return;

            var vm = listbox.DataContext as MainViewModel;

            if (vm == null)
                return;

            if (vm.SelectedObject != null && vm.SelectedObject is Node && vm.SelectedObject.IsNew)
            {
                vm.SelectedObject.X = e.GetPosition(listbox).X;
                vm.SelectedObject.Y = e.GetPosition(listbox).Y;
            }
            else if (vm.SelectedObject != null && vm.SelectedObject is Connector && vm.SelectedObject.IsNew)
            {
                var node = GetNodeUnderMouse();
                if (node == null)
                    return;

                var connector = vm.SelectedObject as Connector;

                if (connector.Start != null && node != connector.Start)
                    connector.End = node;
            }
        }

        private void ListBox_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var vm = DataContext as MainViewModel;
            if (vm != null)
            {
                if (vm.CreatingNewConnector)
                {
                    var node = GetNodeUnderMouse();
                    var connector = vm.SelectedObject as Connector;
                    if (node != null && connector != null && connector.Start == null)
                    {
                        connector.Start = node;
                        node.IsHighlighted = true;
                        e.Handled = true;
                        return;
                    }
                }

                if (vm.SelectedObject != null)
                    vm.SelectedObject.IsNew = false;
                    
                vm.CreatingNewNode = false;
                vm.CreatingNewConnector = false;
            }
        }

        private Node GetNodeUnderMouse()
        {
            var item = Mouse.DirectlyOver as ContentPresenter;
            if (item == null)
                return null;

            return item.DataContext as Node;
        }

    }
}
