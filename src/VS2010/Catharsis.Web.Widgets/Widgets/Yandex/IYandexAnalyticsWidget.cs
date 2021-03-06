﻿using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex.Metrika web counter's JavaScript code.</para>
  /// </summary>
  /// <seealso cref="https://metrika.yandex.ru"/>
  public interface IYandexAnalyticsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies identifier Yandex.Metrica site.</para>
    /// </summary>
    /// <param name="account">Yandex.Metrika identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IYandexAnalyticsWidget Account(string account);

    /// <summary>
    ///   <para>Specifies identifier Yandex.Metrica site.</para>
    /// </summary>
    /// <returns>Yandex.Metrika identifier.</returns>
    string Account();

    /// <summary>
    ///   <para>Specifies whether to use accurate track bounce. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable accurate track bounce functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexAnalyticsWidget Accurate(bool enabled);

    /// <summary>
    ///   <para>Specifies whether to use accurate track bounce. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable accurate track bounce functionality, <c>false</c> to disable it.</returns>
    bool Accurate();

    /// <summary>
    ///   <para>Specifies whether to use click map (gathering statistics for "click map" report). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable click map functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexAnalyticsWidget ClickMap(bool enabled);

    /// <summary>
    ///   <para>Specifies whether to use click map (gathering statistics for "click map" report). Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable click map functionality, <c>false</c> to disable it.</returns>
    bool ClickMap();

    /// <summary>
    ///   <para>Specifies language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language to use.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    IYandexAnalyticsWidget Language(string language);

    /// <summary>
    ///   <para>Specifies language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
    /// </summary>
    /// <returns>Interface language to use.</returns>
    string Language();

    /// <summary>
    ///   <para>Specifies whether to disable indexing of site's pages. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to disable indexing, <c>false</c> to enable it.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexAnalyticsWidget NoIndex(bool enabled);
    
    /// <summary>
    ///   <para>Specifies whether to disable indexing of site's pages. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to disable indexing, <c>false</c> to enable it.</returns>
    bool NoIndex();

    /// <summary>
    ///   <para>Specifies whether to track address hash in URL query string. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable track hash functionality, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexAnalyticsWidget TrackHash(bool enabled);

    /// <summary>
    ///   <para>Specifies whether to track address hash in URL query string. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable track hash functionality, <c>false</c> to disable.</returns>
    bool TrackHash();

    /// <summary>
    ///   <para>Specifies whether to track links (gathering statistics for external links, file uploads and "Share" button). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable track links functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexAnalyticsWidget TrackLinks(bool enabled);

    /// <summary>
    ///   <para>Specifies whether to track links (gathering statistics for external links, file uploads and "Share" button). Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable track links functionality, <c>false</c> to disable it.</returns>
    bool TrackLinks();
   
    /// <summary>
    ///   <para>Specifies whether to use webvisor (recording and analysis of site's visitors behaviour). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable webvisor functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexAnalyticsWidget WebVisor(bool enabled);

    /// <summary>
    ///   <para>Specifies whether to use webvisor (recording and analysis of site's visitors behaviour). Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable webvisor functionality, <c>false</c> to disable it.</returns>
    bool WebVisor();
  }
}