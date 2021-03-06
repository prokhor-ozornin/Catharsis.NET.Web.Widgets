﻿using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuIcqWidget"/>.</para>
  /// </summary>
  public sealed class MailRuIcqWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="MailRuIcqWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuIcqWidget();
      Assert.Null(widget.Account());
      Assert.Null(widget.Language());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuIcqWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuIcqWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new MailRuIcqWidget().Account(string.Empty));

      var widget = new MailRuIcqWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuIcqWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuIcqWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new MailRuIcqWidget().Language(string.Empty));

      var widget = new MailRuIcqWidget();
      Assert.Null(widget.Language());
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.Equal("language", widget.Language());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuIcqWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<script src=""http://c.icq.com/siteim/icqbar/js/partners/initbar_ru.js"" type=""text/javascript""></script>", new MailRuIcqWidget().ToString());

      var html = new MailRuIcqWidget().Account("account").Language("en").ToString();
      Assert.True(html.Contains("window.ICQ = {siteOwner:'account'};"));
      Assert.True(html.Contains(@"<script src=""http://c.icq.com/siteim/icqbar/js/partners/initbar_en.js"" type=""text/javascript""></script>"));
    }
  }
}