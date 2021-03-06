﻿using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders donation form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/donate.xml"/>
  public interface IYandexMoneyDonateFormWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <param name="account">Identifier of account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IYandexMoneyDonateFormWidget Account(string account);

    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <returns>Identifier of account.</returns>
    string Account();

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="accept"><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget Cards(bool accept);

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</returns>
    bool Cards();

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <param name="description">Description of payment purpose.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IYandexMoneyDonateFormWidget DescriptionText(string description);

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <returns>Description of payment purpose.</returns>
    string DescriptionText();

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget AskPayerComment(bool ask);

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</returns>
    bool AskPayerComment();

    /// <summary>
    ///   <para>Hint text for comment field.</para>
    /// </summary>
    /// <param name="hint">Comment's hint.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hint"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hint"/> is <see cref="string.Empty"/> string.</exception>
    IYandexMoneyDonateFormWidget CommentHint(string hint);

    /// <summary>
    ///   <para>Hint text for comment field.</para>
    /// </summary>
    /// <returns>Comment's hint.</returns>
    string CommentHint();

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget AskPayerEmail(bool ask);

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's email required, <c>false</c> to not.</returns>
    bool AskPayerEmail();

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget AskPayerFullName(bool ask);

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's full name required, <c>false</c> to not.</returns>
    bool AskPayerFullName();

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget AskPayerPhone(bool ask);

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's phone required, <c>false</c> to not.</returns>
    bool AskPayerPhone();

    /// <summary>
    ///   <para>Name of charitable project or program.</para>
    /// </summary>
    /// <param name="name">Name of project.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="name"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="name"/> is <see cref="string.Empty"/> string.</exception>
    IYandexMoneyDonateFormWidget ProjectName(string name);

    /// <summary>
    ///   <para>Name of charitable project or program.</para>
    /// </summary>
    /// <returns>Name of project.</returns>
    string ProjectName();

    /// <summary>
    ///   <para>URL address of charitable project or program website.</para>
    /// </summary>
    /// <param name="url">Website of project.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IYandexMoneyDonateFormWidget ProjectSite(string url);

    /// <summary>
    ///   <para>URL address of charitable project or program website.</para>
    /// </summary>
    /// <returns>Website of project.</returns>
    string ProjectSite();

    /// <summary>
    ///   <para>Whether to show description of payment goal/purpose in the form. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show payment purpose text on the form, <c>false</c> to hide it.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget Description(bool show);

    /// <summary>
    ///   <para>Whether to show description of payment goal/purpose in the form. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show payment purpose text on the form, <c>false</c> to hide it.</returns>
    bool Description();

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget Sum(decimal sum);

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <returns>Payment sum.</returns>
    decimal? Sum();

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Donate").</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyDonateFormWidget Text(byte text);

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Donate").</para>
    /// </summary>
    /// <returns>Numeric code of text to display.</returns>
    byte Text();
  }
}