using System;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed partial class HtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.SoundCloud(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void SoundCloud_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.SoundCloud(null));

      Assert.NotNull(html.SoundCloud());
      Assert.True(ReferenceEquals(html.SoundCloud(), html.SoundCloud()));
    }
  }
}