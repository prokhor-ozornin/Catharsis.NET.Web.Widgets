using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte community widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Community"/>
  public interface IVkontakteCommunityWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Background color of widget.</para>
    /// </summary>
    /// <param name="color">Widget's background color in RRGGBB format.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget BackgroundColor(string color);

    /// <summary>
    ///   <para>Background color of widget.</para>
    /// </summary>
    /// <returns>Widget's background color in RRGGBB format.</returns>
    string BackgroundColor();

    /// <summary>
    ///   <para>Text color of widget.</para>
    /// </summary>
    /// <param name="color">Widget's text color in RRGGBB format.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget TextColor(string color);

    /// <summary>
    ///   <para>Text color of widget.</para>
    /// </summary>
    /// <returns>Widget's text color in RRGGBB format.</returns>
    string TextColor();

    /// <summary>
    ///   <para>Button color of widget.</para>
    /// </summary>
    /// <param name="color">Widget's button color in RRGGBB format.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget ButtonColor(string color);

    /// <summary>
    ///   <para>Button color of widget.</para>
    /// </summary>
    /// <returns>Widget's button color in RRGGBB format.</returns>
    string ButtonColor();

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget ElementId(string id);

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    string ElementId();

    /// <summary>
    ///   <para>Identifier or VKontakte public group/community.</para>
    /// </summary>
    /// <param name="account">Group identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontakteCommunityWidget Account(string account);

    /// <summary>
    ///   <para>Identifier or VKontakte public group/community.</para>
    /// </summary>
    /// <returns>Group identifier.</returns>
    string Account();

    /// <summary>
    ///   <para>Vertical height of widget.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget Height(string height);

    /// <summary>
    ///   <para>Vertical height of widget.</para>
    /// </summary>
    /// <returns>Height of widget.</returns>
    string Height();

    /// <summary>
    ///   <para>Type of information to be displayed about given community.</para>
    /// </summary>
    /// <param name="mode">Community's info type.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteCommunityWidget Mode(byte mode);

    /// <summary>
    ///   <para>Type of information to be displayed about given community.</para>
    /// </summary>
    /// <returns>Community's info type.</returns>
    byte Mode();

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget Width(string width);

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <returns>Width of widget.</returns>
    string Width();
  }
}