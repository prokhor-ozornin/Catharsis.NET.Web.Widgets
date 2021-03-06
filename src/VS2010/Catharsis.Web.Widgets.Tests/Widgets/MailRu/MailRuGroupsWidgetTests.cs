﻿using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuGroupsWidget"/>.</para>
  /// </summary>
  public sealed class MailRuGroupsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="MailRuGroupsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Account());
      Assert.Null(widget.BackgroundColor());
      Assert.Null(widget.ButtonColor());
      Assert.Null(widget.Domain());
      Assert.Null(widget.Height());
      Assert.True(widget.Subscribers());
      Assert.Null(widget.TextColor());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Account(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.BackgroundColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void BackgroundColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().BackgroundColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().BackgroundColor(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.BackgroundColor());
      Assert.True(ReferenceEquals(widget.BackgroundColor("backgroundColor"), widget));
      Assert.Equal("backgroundColor", widget.BackgroundColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.ButtonColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ButtonColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().ButtonColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().ButtonColor(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.ButtonColor());
      Assert.True(ReferenceEquals(widget.ButtonColor("buttonColor"), widget));
      Assert.Equal("buttonColor", widget.ButtonColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Domain(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Domain_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Domain(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Domain(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Domain());
      Assert.True(ReferenceEquals(widget.Domain("domain"), widget));
      Assert.Equal("domain", widget.Domain());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Height(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Subscribers(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Subscribers_Method()
    {
      var widget = new MailRuGroupsWidget();
      Assert.True(widget.Subscribers());
      Assert.True(ReferenceEquals(widget.Subscribers(false), widget));
      Assert.False(widget.Subscribers());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.TextColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().TextColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().TextColor(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.TextColor());
      Assert.True(ReferenceEquals(widget.TextColor("textColor"), widget));
      Assert.Equal("textColor", widget.TextColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Width(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new MailRuGroupsWidget().ToString());
      Assert.Equal(string.Empty, new MailRuGroupsWidget().Account("account").Width("width").ToString());
      Assert.Equal(string.Empty, new MailRuGroupsWidget().Account("account").Height("height").ToString());
      Assert.Equal(string.Empty, new MailRuGroupsWidget().Width("width").Height("height").ToString());
      Assert.Equal(@"<a class=""mrc__plugin_groups_widget"" href=""http://connect.mail.ru/groups_widget?group=account&amp;max_sub=50&amp;width=width&amp;height=height&amp;show_subscribers=true"" rel=""{&quot;group&quot;:&quot;account&quot;,&quot;max_sub&quot;:50,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;show_subscribers&quot;:true}"" target=""_blank"">Группы</a>", new MailRuGroupsWidget().Account("account").Width("width").Height("height").ToString());
      Assert.Equal(@"<a class=""mrc__plugin_groups_widget"" href=""http://connect.mail.ru/groups_widget?group=account&amp;max_sub=50&amp;width=width&amp;height=height&amp;background=backgroundColor&amp;color=textColor&amp;button_background=buttonColor&amp;domain=domain"" rel=""{&quot;group&quot;:&quot;account&quot;,&quot;max_sub&quot;:50,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;button_background&quot;:&quot;buttonColor&quot;,&quot;domain&quot;:&quot;domain&quot;}"" target=""_blank"">Группы</a>", new MailRuGroupsWidget().Account("account").Width("width").Height("height").Subscribers(false).BackgroundColor("backgroundColor").TextColor("textColor").ButtonColor("buttonColor").Domain("domain").ToString());
    }
  }
}