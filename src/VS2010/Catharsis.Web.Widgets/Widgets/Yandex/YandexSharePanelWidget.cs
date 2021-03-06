using System;
using System.Collections.Generic;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex social "Share" button.</para>
  ///   <para>Requires Yandex scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Yandex(IWidgetsScriptsRenderer)"/>
  public class YandexSharePanelWidget : HtmlWidget, IYandexSharePanelWidget
  {
    private string language;
    private string layout = YandexSharePanelLayout.Button.ToString().ToLowerInvariant();
    private IEnumerable<string> services = new [] { "yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird" };

    /// <summary>
    ///   <para>Button's interface language.</para>
    /// </summary>
    /// <param name="language">Interface language.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexSharePanelWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Button's interface language.</para>
    /// </summary>
    /// <returns>Interface language.</returns>
    public string Language()
    {
      return this.language;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexSharePanelWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);
      
      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    public string Layout()
    {
      return this.layout;
    }

    /// <summary>
    ///   <para>List of included social services. Valid names include : [yaru, vkontakte, facebook, twitter, odnoklassniki ,moimir, lj, friendfeed, moikrug, gplus, pinterest, surfingbird].</para>
    /// </summary>
    /// <param name="services">List of social services for which to render buttons.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="services"/> is a <c>null</c> reference.</exception>
    public IYandexSharePanelWidget Services(IEnumerable<string> services)
    {
      Assertion.NotNull(services);

      this.services = services;
      return this;
    }

    /// <summary>
    ///   <para>List of included social services. Valid names include : [yaru, vkontakte, facebook, twitter, odnoklassniki ,moimir, lj, friendfeed, moikrug, gplus, pinterest, surfingbird].</para>
    /// </summary>
    /// <returns>List of social services for which to render buttons.</returns>
    public IEnumerable<string> Services()
    {
      return this.services;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      return new TagBuilder("div")
        .Attribute("data-yashareL10n", this.Language() ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
        .Attribute("data-yashareType", this.Layout())
        .Attribute("data-yashareQuickServices", this.Services().Join(","))
        .CssClass("yashare-auto-init")
        .ToString();
    }
  }
}