﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleMvcUserManagement.Scripts {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ScriptPack {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ScriptPack() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SimpleMvcUserManagement.Scripts.ScriptPack", typeof(ScriptPack).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;form id=&quot;add-user-form&quot;&gt;
        ///&lt;fieldset&gt;
        ///	&lt;legend&gt;Add User&lt;/legend&gt;
        ///	&lt;!--&lt;div id=&quot;basic-user-info&quot;&gt;--&gt;
        ///		&lt;div class=&quot;editor-label&quot;&gt;
        ///			&lt;label for=&quot;tbx-add-username&quot;&gt;
        ///				Name&lt;/label&gt;
        ///		&lt;/div&gt;
        ///		&lt;div class=&quot;editor-field&quot;&gt;
        ///			&lt;input type=&quot;text&quot; id=&quot;tbx-add-username&quot; placeholder=&quot;e.g. John&quot;/&gt;&lt;/div&gt;
        ///		&lt;div class=&quot;editor-label&quot;&gt;
        ///			&lt;label for=&quot;tbx-add-password&quot;&gt;
        ///				Password&lt;/label&gt;
        ///		&lt;/div&gt;
        ///		&lt;div class=&quot;editor-field&quot;&gt;
        ///			&lt;input type=&quot;password&quot; id=&quot;tbx-add-password&quot; placeholder=&quot;password&quot;/&gt;
        ///		&lt;/div&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string add_user_form {
            get {
                return ResourceManager.GetString("add_user_form", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* TableSorter 2.0 - Client-side table sorting with ease!
        ///* Version 2.0.28 Minified using http://dean.edwards.name/packer/
        ///* Copyright (c) 2007 Christian Bach
        ///*/
        ///
        ///!(function ($) { $.extend({ tablesorter: new function () { var g = [], widgets = [], tbl; this.defaults = { cssHeader: &quot;header&quot;, cssAsc: &quot;headerSortUp&quot;, cssDesc: &quot;headerSortDown&quot;, cssChildRow: &quot;expand-child&quot;, sortInitialOrder: &quot;asc&quot;, sortMultiSortKey: &quot;shiftKey&quot;, sortForce: null, sortAppend: null, sortLocaleCompare: false, textExtraction:  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jquery_tablesorter_min {
            get {
                return ResourceManager.GetString("jquery_tablesorter_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;form id=&quot;manage-roles-form&quot;&gt;
        ///&lt;fieldset&gt;
        ///	&lt;legend&gt;Manage Roles&lt;/legend&gt;
        ///	&lt;div class=&quot;editor-label&quot;&gt;
        ///		&lt;label for=&quot;role-name&quot;&gt;
        ///			Rolename&lt;/label&gt;&lt;/div&gt;
        ///	&lt;div class=&quot;editor-field&quot;&gt;
        ///		&lt;input type=&quot;text&quot; id=&quot;role-name&quot; placeholder=&quot;e.g. test&quot; /&gt;&lt;/div&gt;
        ///	&lt;input type=&quot;button&quot; id=&quot;btn-add-role&quot; value=&quot;Add Role&quot; /&gt;
        ///	&lt;div class=&quot;editor-label&quot;&gt;
        ///		All roles&lt;/div&gt;
        ///	&lt;div class=&quot;editor-field&quot;&gt;
        ///		&lt;select id=&quot;add-user-roles&quot; size=&quot;10&quot; class=&quot;role-select-box&quot;&gt;
        ///		&lt;/select&gt;
        ///	&lt;/div&gt;
        ///	&lt;label for=&quot;allow-populated- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string manage_roles_form {
            get {
                return ResourceManager.GetString("manage_roles_form", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///$(function () {
        ///
        ///  var addUserArea = new AddUserArea();
        ///  addUserArea.init(&quot;.simple-user-table&quot;);
        ///
        ///  var roleMgmt = new RoleManagement();
        ///  roleMgmt.init();
        ///
        ///  var userTableArea = new UserTableArea();
        ///  userTableArea.init(&quot;.simple-user-table&quot;);
        ///
        ///});
        ///
        ///
        ///
        ///function UserTableArea() {
        ///
        ///  var userTable;
        ///
        ///  /* Initializes the user table and fills it with server data. */
        ///  this.init = function (tableSelector) {
        ///
        ///    // get user table
        ///    userTable = $(tableSelector);
        ///
        ///    // fill the user  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string simple_user_management {
            get {
                return ResourceManager.GetString("simple_user_management", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #simple-user-info {
        ///  padding: 15px 0;
        ///  text-align:center;  
        ///  background-repeat: no-repeat;
        ///  background-position: 10px center;
        ///  position: relative;
        ///  color: #00529B;
        ///  position: fixed;
        ///  top: 0;
        ///  width: 100%;
        ///  filter:alpha(opacity=95); /* IE */
        ///-moz-opacity: 0.95; /* Mozilla */
        ///opacity: 0.95; /* Opera */
        ///}
        ///#simple-user-info.error {
        ///  background-color: Yellow;
        ///}
        ///#simple-user-info.success {
        ///  background-color: Lime;
        ///}
        ///
        ///
        ///#add-user-form,#manage-roles-form{
        ///  display:inline-block
        ///}        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string style {
            get {
                return ResourceManager.GetString("style", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* tablesorter pager plugin
        ///* updated 1/31/2012
        ///*/
        ///
        ///(function ($) {
        ///  $.extend({ tablesorterPager: new function () {
        ///
        ///    // hide arrows at extremes
        ///    var pagerArrows = function (c) {
        ///      var a = &apos;addClass&apos;, r = &apos;removeClass&apos;, d = c.cssDisabled;
        ///      if (c.updateArrows) {
        ///        c.container[(c.totalRows &lt; c.size) ? a : r](d);
        ///        $(c.cssFirst + &apos;,&apos; + c.cssPrev, c.container)[(c.page === 0) ? a : r](d);
        ///        $(c.cssNext + &apos;,&apos; + c.cssLast, c.container)[(c.page === c.totalPages - 1) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tablesorter_pager {
            get {
                return ResourceManager.GetString("tablesorter_pager", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (function (a) { a.extend({ tablesorterPager: new function () { var b = function (b) { var c = &quot;addClass&quot;, d = &quot;removeClass&quot;, e = b.cssDisabled; if (b.updateArrows) { b.container[b.totalRows &lt; b.size ? c : d](e); a(b.cssFirst + &quot;,&quot; + b.cssPrev, b.container)[b.page === 0 ? c : d](e); a(b.cssNext + &quot;,&quot; + b.cssLast, b.container)[b.page === b.totalPages - 1 ? c : d](e) } }, c = function (c, d) { d.startRow = d.size * d.page + 1; d.endRow = Math.min(d.totalRows, d.size * (d.page + 1)); var e = a(d.cssPageDisplay, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tablesorter_pager_min {
            get {
                return ResourceManager.GetString("tablesorter_pager_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* tables */
        ///table.tablesorter {
        ///	background-color: #CDCDCD;
        ///	margin:10px 0pt 15px;
        ///	width: 100%;
        ///	text-align: left;
        ///}
        ///table.tablesorter thead tr th, table.tablesorter tfoot tr th {
        ///	background-color: #e6EEEE !important;
        ///	border: 1px solid #FFF;
        ///	padding: 4px;
        ///}
        ///table.tablesorter thead tr .header {
        ///	cursor: pointer;
        ///}
        ///table.tablesorter tbody td {
        ///	
        ///	padding: 4px;
        ///	background-color: #FFF;
        ///	vertical-align: top;
        ///}
        ///table.tablesorter tbody tr.odd td {
        ///	background-color:#F0F0F6;
        ///}
        ///table.tablesorter thead tr .head [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tablesorter_style {
            get {
                return ResourceManager.GetString("tablesorter_style", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;fieldset class=&quot;simple-user-table-field&quot;&gt;
        ///&lt;legend&gt;User Table&lt;/legend&gt;
        ///	&lt;table class=&apos;simple-user-table tablesorter&apos;&gt;
        ///		&lt;thead&gt;
        ///			&lt;tr&gt;
        ///				&lt;th&gt;
        ///					ID
        ///				&lt;/th&gt;
        ///				&lt;th&gt;
        ///					Name
        ///				&lt;/th&gt;
        ///				&lt;th&gt;
        ///					Registration
        ///				&lt;/th&gt;
        ///				&lt;th&gt;
        ///					E-Mail
        ///				&lt;/th&gt;
        ///				&lt;th&gt;
        ///					LockIn/Out
        ///				&lt;/th&gt;
        ///				&lt;th&gt;
        ///					Action
        ///				&lt;/th&gt;
        ///			&lt;/tr&gt;
        ///		&lt;/thead&gt;
        ///		&lt;tbody&gt;
        ///		&lt;/tbody&gt;
        ///	&lt;/table&gt;
        ///	&lt;div id=&quot;pager&quot; class=&quot;tablesorter pager&quot;&gt;
        ///		&lt;form&gt;
        ///		&lt;button class=&quot;first&quot;&gt;
        ///			&lt;&lt;&lt;/button&gt;
        ///		&lt;button  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string user_table_area {
            get {
                return ResourceManager.GetString("user_table_area", resourceCulture);
            }
        }
    }
}
