﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex.Metrika web counter's JavaScript code.</para>
  /// </summary>
  /// <seealso cref="https://metrika.yandex.ru"/>
  public class YandexAnalyticsWidget : HtmlWidget, IYandexAnalyticsWidget
  {
    private string account;
    private bool webVisor = true;
    private bool clickMap = true;
    private bool trackLinks = true;
    private bool trackHash = true;
    private bool accurate = true;
    private bool noIndex;
    private string language;

    /// <summary>
    ///   <para>Identifier Yandex.Metrica site.</para>
    /// </summary>
    /// <param name="account">Yandex.Metrika identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexAnalyticsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Identifier Yandex.Metrica site.</para>
    /// </summary>
    /// <returns>Yandex.Metrika identifier.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Whether to use accurate track bounce. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable accurate track bounce functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget Accurate(bool enabled)
    {
      this.accurate = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to use accurate track bounce. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable accurate track bounce functionality, <c>false</c> to disable it.</returns>
    public bool Accurate()
    {
      return this.accurate;
    }

    /// <summary>
    ///   <para>Whether to use click map (gathering statistics for "click map" report). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable click map functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget ClickMap(bool enabled)
    {
      this.clickMap = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to use click map (gathering statistics for "click map" report). Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable click map functionality, <c>false</c> to disable it.</returns>
    public bool ClickMap()
    {
      return this.clickMap;
    }

    /// <summary>
    ///   <para>Language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language to use.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexAnalyticsWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
    /// </summary>
    /// <returns>Interface language to use.</returns>
    public string Language()
    {
      return this.language;
    }

    /// <summary>
    ///   <para>Whether to disable indexing of site's pages. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to disable indexing, <c>false</c> to enable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget NoIndex(bool enabled)
    {
      this.noIndex = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to disable indexing of site's pages. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to disable indexing, <c>false</c> to enable it.</returns>
    public bool NoIndex()
    {
      return this.noIndex;
    }

    /// <summary>
    ///   <para>Whether to track address hash in URL query string. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable track hash functionality, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget TrackHash(bool enabled)
    {
      this.trackHash = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to track address hash in URL query string. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable track hash functionality, <c>false</c> to disable.</returns>
    public bool TrackHash()
    {
      return this.trackHash;
    }

    /// <summary>
    ///   <para>Whether to track links (gathering statistics for external links, file uploads and "Share" button). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable track links functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget TrackLinks(bool enabled)
    {
      this.trackLinks = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to track links (gathering statistics for external links, file uploads and "Share" button). Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable track links functionality, <c>false</c> to disable it.</returns>
    public bool TrackLinks()
    {
      return this.trackLinks;
    }

    /// <summary>
    ///   <para>Whether to use webvisor (recording and analysis of site's visitors behaviour). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable webvisor functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget WebVisor(bool enabled)
    {
      this.webVisor = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to use webvisor (recording and analysis of site's visitors behaviour). Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable webvisor functionality, <c>false</c> to disable it.</returns>
    public bool WebVisor()
    {
      return this.webVisor;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object>
      {
        { "id", this.Account() },
        { "webvisor", this.WebVisor() },
        { "clickmap", this.ClickMap() },
        { "trackLinks", this.TrackLinks() },
        { "accurateTrackBounce", this.Accurate() },
        { "trackHash", this.TrackHash() }
      };
      if (this.NoIndex())
      {
        config["ut"] = "noindex";
      }

      return resources.yandex_analytics.FormatSelf(this.Account(), this.Language() ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), config.Json());
    }
  }
}