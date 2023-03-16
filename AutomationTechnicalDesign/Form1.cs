using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AutomationTechnicalDesign.Controller;
using AutomationTechnicalDesign.Models;
using Action = AutomationTechnicalDesign.Models.Action;

namespace AutomationTechnicalDesign;

public partial class Form1 : Form
{
    private readonly List<Operation> _operations;
    private readonly List<Action> _actions;
    private readonly List<Objects> _objects;
    private readonly List<Tool> _tools;
    private readonly List<Controls> _controls;
    private readonly List<Tooling> _toolings;
    private static int _index;

    public Form1()
    {
        InitializeComponent();
        _operations = AddingData.GetOperations();
        _actions = AddingData.GetActions();
        _objects = AddingData.GetObjects();
        _tools = AddingData.GetTools();
        _controls = AddingData.GetControls();
        _toolings = AddingData.GetToolings();
        _index = -1;
        _operations.Select(operation => operation.Name).ToList().ForEach(name => operationComboBox.Items.Add(name));
    }

    private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (operationComboBox.SelectedItem == null) return;
        actionComboBox.Items.Clear();
        toolComboBox.Items.Clear();
        var operation = _operations.First(oper => oper.Name.Equals(operationComboBox.SelectedItem.ToString()));
        var actionsNames = from action in _actions
            where action.OperationsId.Any(id => id.Equals(operation.Id))
            select action.Name;
        foreach (var name in actionsNames)
            actionComboBox.Items.Add(name);
        var toolsNames = from tool in _tools
            where tool.OperationsId.Any(id => id.Equals(operation.Id))
            select tool.Name;
        foreach (var name in toolsNames)
            toolComboBox.Items.Add(name);
        transitionTextBox.Text = "";
        technologicalEquipmentTextBox.Text = "";
        size1IdTextBox.Text = "";
        size2IdTextBox.Text = "";
        size3IdTextBox.Text = "";
        size1NumericUpDown.Value = 0;
        size2NumericUpDown.Value = 0;
        size3NumericUpDown.Value = 0;
        idNumericUpDown.Value = 1;
        objectComboBox.Items.Clear();
        toolingComboBox.Items.Clear();
        controlsComboBox.Items.Clear();
    }

    private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (actionComboBox.SelectedItem == null) return;
        objectComboBox.Items.Clear();
        var action = _actions.First(acti => acti.Name.Equals(actionComboBox.SelectedItem.ToString()));
        var names = from @object in _objects
            where @object.ConditionalId.Any(id => id.Equals(action.Id))
            select @object.Name;
        foreach (var name in names)
            objectComboBox.Items.Add(name);
        transitionTextBox.Text = actionComboBox.SelectedItem.ToString();
    }
    
    private void objectComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (objectComboBox.SelectedItem == null) return;
        transitionTextBox.Text = transitionTextBox.Text.Split(' ')[0] + $@" {objectComboBox.SelectedItem} {idNumericUpDown.Text},";
    }

    private void operationAddButton_Click(object sender, EventArgs e)
    {
        if (operationComboBox.SelectedItem is null) return;
        computerAidedDesignProcessTreeView.Nodes.Add(operationComboBox.SelectedItem.ToString());
        _index++;
    }

    private void technologicalEquipmentAddButton_Click(object sender, EventArgs e)
    {
        if (computerAidedDesignProcessTreeView.Nodes.Count == 0) return;
        computerAidedDesignProcessTreeView.Nodes[_index].Nodes.Add(technologicalEquipmentTextBox.Text);
    }

    private void transitionAddButton_Click(object sender, EventArgs e)
    {
        if (computerAidedDesignProcessTreeView.Nodes.Count == 0) return;
        
        computerAidedDesignProcessTreeView.Nodes[_index].Nodes.Add(transitionTextBox.Text);
    }

    private void idNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        if (transitionTextBox.Text.Any(char.IsDigit))
        {
            transitionTextBox.Text = $@"{actionComboBox.SelectedItem} {objectComboBox.SelectedItem} {idNumericUpDown.Value},";
        }
    }

    private void toolComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (toolComboBox.SelectedItem is null) return;
        toolingComboBox.Items.Clear();
        controlsComboBox.Items.Clear();
        var tool = _tools.First(oper => oper.Name.Equals(toolComboBox.SelectedItem.ToString()));
        var names = from tooling in _toolings
            where tooling.ToolsId.Any(id => id.Equals(tool.Id))
            select tooling.Name;
        foreach (var name in names)
            toolingComboBox.Items.Add(name);
        technologicalEquipmentTextBox.Text = toolComboBox.SelectedItem.ToString();
    }

    private void toolingComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (toolingComboBox.SelectedItem is null) return;
        controlsComboBox.Items.Clear();
        var tooling = _toolings.First(oper => oper.Name.Equals(toolingComboBox.SelectedItem.ToString()));
        var names = from controls in _controls
            where controls.ToolsId.Any(id => id.Equals(tooling.Id))
            select controls.Name;
        foreach (var name in names)
            controlsComboBox.Items.Add(name);
        technologicalEquipmentTextBox.Text = $@"{toolComboBox.SelectedItem}, {toolingComboBox.SelectedItem}";
    }

    private void size1IdTextBox_TextChanged(object sender, EventArgs e)
    {
        transitionTextBox.Text = $@"{actionComboBox.SelectedItem} {objectComboBox.SelectedItem} {idNumericUpDown.Value}, {size1IdTextBox.Text}";
    }

    private void size1NumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        transitionTextBox.Text = $@"{actionComboBox.SelectedItem} {objectComboBox.SelectedItem} {idNumericUpDown.Value}, {size1IdTextBox.Text} = {size1NumericUpDown.Value}";
    }

    private void size2IdTextBox_TextChanged(object sender, EventArgs e)
    {
        transitionTextBox.Text = $@"{actionComboBox.SelectedItem} {objectComboBox.SelectedItem} {idNumericUpDown.Value}, {size1IdTextBox.Text} = {size1NumericUpDown.Value}, {size2IdTextBox.Text}";
    }

    private void size2NumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        transitionTextBox.Text = $@"{actionComboBox.SelectedItem} {objectComboBox.SelectedItem} {idNumericUpDown.Value}, {size1IdTextBox.Text} = {size1NumericUpDown.Value}, {size2IdTextBox.Text} = {size2NumericUpDown.Value}";
    }

    private void size3IdTextBox_TextChanged(object sender, EventArgs e)
    {
        transitionTextBox.Text = $@"{actionComboBox.SelectedItem} {objectComboBox.SelectedItem} {idNumericUpDown.Value}, {size1IdTextBox.Text} = {size1NumericUpDown.Value}, {size2IdTextBox.Text} = {size2NumericUpDown.Value}, {size3IdTextBox.Text}";
    }

    private void size3NumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        transitionTextBox.Text = $@"{actionComboBox.SelectedItem} {objectComboBox.SelectedItem} {idNumericUpDown.Value}, {size1IdTextBox.Text} = {size1NumericUpDown.Value}, {size2IdTextBox.Text} = {size2NumericUpDown.Value}, {size3IdTextBox.Text} = {size3NumericUpDown.Value}";
    }

    private void controlsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        technologicalEquipmentTextBox.Text = $@"{toolComboBox.SelectedItem}, {toolingComboBox.SelectedItem}, {controlsComboBox.SelectedItem}";
    }

    private void operationDeleteButton_Click(object sender, EventArgs e)
    {
        computerAidedDesignProcessTreeView.SelectedNode.Remove();
    }
}