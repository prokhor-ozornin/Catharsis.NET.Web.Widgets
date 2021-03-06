﻿using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookLikeBoxWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookLikeBoxWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeBoxWidgetExtensions.Width(IFacebookLikeBoxWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeBoxWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookLikeBoxWidget().Width(1).Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeBoxWidgetExtensions.Height(IFacebookLikeBoxWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeBoxWidgetExtensions.Height(null, 0));

      Assert.Equal("1", new FacebookLikeBoxWidget().Height(1).Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeBoxWidgetExtensions.ColorScheme(IFacebookLikeBoxWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeBoxWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookLikeBoxWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
      Assert.Equal("light", new FacebookLikeBoxWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
    }
  }
}