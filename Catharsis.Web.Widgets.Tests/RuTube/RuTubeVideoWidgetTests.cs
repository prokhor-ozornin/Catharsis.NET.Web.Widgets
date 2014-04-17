﻿using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="RuTubeVideoWidget"/>.</para>
  /// 
  /// </summary>
  public sealed class RuTubeVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="RuTubeVideoWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new RuTubeVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      var widget = new RuTubeVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new RuTubeVideoWidget().Width(string.Empty));

      var widget = new RuTubeVideoWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new RuTubeVideoWidget().Height(string.Empty));

      var widget = new RuTubeVideoWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new RuTubeVideoWidget().ToString());
      Assert.Equal(string.Empty, new RuTubeVideoWidget().Id("id").Height("height").ToString());
      Assert.Equal(string.Empty, new RuTubeVideoWidget().Id("id").Width("width").ToString());
      Assert.Equal(string.Empty, new RuTubeVideoWidget().Height("height").Width("width").ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" scrolling=""no"" src=""http://rutube.ru/embed/id"" webkitallowfullscreen=""true"" width=""width""></iframe>", new RuTubeVideoWidget().Id("id").Height("height").Width("width").ToString());
    }
  }
}