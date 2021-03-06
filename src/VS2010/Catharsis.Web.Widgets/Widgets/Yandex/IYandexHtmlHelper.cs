namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Yandex widgets.</para>
  /// </summary>
  public interface IYandexHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Yandex.Metrika analytics widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexAnalyticsWidget Analytics();

    /// <summary>
    ///   <para>Creates new Yandex "Like" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexLikeButtonWidget LikeButton();

    /*/// <summary>
    ///   <para>Creates new Yandex Map widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexMapWidget Map();*/

    /// <summary>
    ///   <para>Creates new Yandex.Money button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexMoneyButtonWidget MoneyButton();

    /// <summary>
    ///   <para>Creates new Yandex.Money donation form widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexMoneyDonateFormWidget MoneyDonateForm();

    /// <summary>
    ///   <para>Creates new Yandex.Money payment form widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexMoneyPaymentFormWidget MoneyPaymentForm();

    /// <summary>
    ///   <para>Creates new Yandex "Share" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexSharePanelWidget SharePanel();

    /// <summary>
    ///   <para>Creates new Yandex embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYandexVideoWidget Video();
  }
}