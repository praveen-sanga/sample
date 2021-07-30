﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Microsoft.Samples.HttpCookieSession
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.Samples.HttpCookieSession", ConfigurationName="Microsoft.Samples.HttpCookieSession.IShoppingCart", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IShoppingCart
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/AddItem", ReplyAction="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/AddItemResponse")]
        int AddItem(int itemId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/Clear", ReplyAction="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/ClearResponse")]
        int Clear();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/RemoveItem", ReplyAction="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/RemoveItemResponse")]
        int RemoveItem(int itemId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/ItemCount", ReplyAction="http://Microsoft.Samples.HttpCookieSession/IShoppingCart/ItemCountResponse")]
        int ItemCount();

        [System.ServiceModel.OperationContractAttribute(Action = "http://Microsoft.Samples.HttpCookieSession/IShoppingCart/GetItems", ReplyAction = "http://Microsoft.Samples.HttpCookieSession/IShoppingCart/GetItemsResponse")]
        System.Collections.Generic.Dictionary<int, int> GetItems();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoppingCartChannel : Microsoft.Samples.HttpCookieSession.IShoppingCart, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoppingCartClient : System.ServiceModel.ClientBase<Microsoft.Samples.HttpCookieSession.IShoppingCart>, Microsoft.Samples.HttpCookieSession.IShoppingCart
    {
        
        public ShoppingCartClient()
        {
        }
        
        public ShoppingCartClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ShoppingCartClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ShoppingCartClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ShoppingCartClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int AddItem(int itemId, int quantity)
        {
            return base.Channel.AddItem(itemId, quantity);
        }
        
        public int Clear()
        {
            return base.Channel.Clear();
        }
        
        public int RemoveItem(int itemId, int quantity)
        {
            return base.Channel.RemoveItem(itemId, quantity);
        }
        
        public int ItemCount()
        {
            return base.Channel.ItemCount();
        }

        public System.Collections.Generic.Dictionary<int, int> GetItems()
        {
            return base.Channel.GetItems();
        }
    }
}