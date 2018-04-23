# How to embed an existing layoutControl into another layoutControl's empty group


<p>This example demonstrates how to embed an existing layoutControl into another layoutControl's empty group</p>


<h3>Description</h3>

<p>To put the LayoutControl in LayoutControlGroup of another layout, use the LayoutControlGroup.AddItem method. This method receives a LayoutControlItem object. Thus, at first we need to create a new LayoutControlItem instance, put LayoutControl1 in the Control property of the item, and after this call the LayoutControlGroup.AddItem method.</p>

<br/>


