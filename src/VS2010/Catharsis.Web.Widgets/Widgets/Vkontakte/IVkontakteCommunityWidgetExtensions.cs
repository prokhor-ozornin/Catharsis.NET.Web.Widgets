using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontakteCommunityWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVkontakteCommunityWidget"/>
  public static class IVkontakteCommunityWidgetExtensions
  {
    /// <summary>
    ///   <para>Type of information to be displayed about given community.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="mode">Community's info type.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommunityWidget.Mode(byte)"/>
    public static IVkontakteCommunityWidget Mode(this IVkontakteCommunityWidget widget, VkontakteCommunityMode mode)
    {
      Assertion.NotNull(widget);

      return widget.Mode((byte)mode);
    }

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommunityWidget.Width(string)"/>
    public static IVkontakteCommunityWidget Width(this IVkontakteCommunityWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Vertical height of widget.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommunityWidget.Height(string)"/>
    public static IVkontakteCommunityWidget Height(this IVkontakteCommunityWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }
  }
}