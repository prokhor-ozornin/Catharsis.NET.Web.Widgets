﻿using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SurfingbirdSurfButtonWidget"/>.</para>
  /// </summary>
  public sealed class SurfingbirdSurfButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="SurfingbirdSurfButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Url());
      Assert.Equal(SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant(), widget.Layout());
      Assert.Null(widget.Width());
      Assert.Null(widget.Height());
      Assert.False(widget.Counter());
      Assert.Equal("Surf", widget.Label());
      Assert.Null(widget.Color());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Url(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Layout(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Equal(SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant(), widget.Layout());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.Equal("layout", widget.Layout());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Width(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Height(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Counter(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Counter_Method()
    {
      var widget = new SurfingbirdSurfButtonWidget();
      Assert.False(widget.Counter());
      Assert.True(ReferenceEquals(widget.Counter(true), widget));
      Assert.True(widget.Counter());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Label(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Label_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Label(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Label(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Equal("Surf", widget.Label());
      Assert.True(ReferenceEquals(widget.Label("label"), widget));
      Assert.Equal("label", widget.Label());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Color(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Color_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Color(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Color(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Color());
      Assert.True(ReferenceEquals(widget.Color("color"), widget));
      Assert.Equal("color", widget.Color());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<a class=""surfinbird__like_button"" data-surf-config=""{&quot;layout&quot;:&quot;common-nocount&quot;}"" href=""http://surfingbird.ru/share"" target=""_blank"">Surf</a>", new SurfingbirdSurfButtonWidget().ToString());
      Assert.Equal(@"<a class=""surfinbird__like_button"" data-surf-config=""{&quot;layout&quot;:&quot;common-blue&quot;,&quot;url&quot;:&quot;url&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}"" href=""http://surfingbird.ru/share"" target=""_blank"">Share</a>", new SurfingbirdSurfButtonWidget().Color(SurfingbirdSurfButtonColor.Blue).Counter(true).Label("Share").Url("url").Layout(SurfingbirdSurfButtonLayout.Common).Width("width").Height("height").ToString());
    }
  }
}