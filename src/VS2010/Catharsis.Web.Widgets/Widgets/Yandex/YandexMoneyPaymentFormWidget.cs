﻿using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders payment form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/shop.xml"/>
  public class YandexMoneyPaymentFormWidget : HtmlWidget, IYandexMoneyPaymentFormWidget
  {
    private string account;
    private string description;
    private decimal? sum;
    private bool cards = true;
    private byte text = (byte) YandexMoneyPaymentFormText.Pay;
    private bool askPayerPurpose;
    private bool askPayerComment;
    private bool askPayerFullName;
    private bool askPayerEmail;
    private bool askPayerPhone;
    private bool askPayerAddress;

    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <param name="account">Identifier of account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyPaymentFormWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <returns>Identifier of account.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="accept"><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget Cards(bool accept)
    {
      this.cards = accept;
      return this;
    }

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</returns>
    public bool Cards()
    {
      return this.cards;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose (for predefined purpose) or purpose hint (for custom purpose).</para>
    /// </summary>
    /// <param name="description">Description of purpose/purpose hint.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyPaymentFormWidget Description(string description)
    {
      Assertion.NotEmpty(description);

      this.description = description;
      return this;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose (for predefined purpose) or purpose hint (for custom purpose).</para>
    /// </summary>
    /// <returns>Description of purpose/purpose hint.</returns>
    public string Description()
    {
      return this.description;
    }

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's address required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerAddress(bool ask)
    {
      this.askPayerAddress = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's address required, <c>false</c> to not.</returns>
    public bool AskPayerAddress()
    {
      return this.askPayerAddress;
    }

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerComment(bool ask)
    {
      this.askPayerComment = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</returns>
    public bool AskPayerComment()
    {
      return this.askPayerComment;
    }

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerEmail(bool ask)
    {
      this.askPayerEmail = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's email required, <c>false</c> to not.</returns>
    public bool AskPayerEmail()
    {
      return this.askPayerEmail;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerFullName(bool ask)
    {
      this.askPayerFullName = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's full name required, <c>false</c> to not.</returns>
    public bool AskPayerFullName()
    {
      return this.askPayerFullName;
    }

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerPhone(bool ask)
    {
      this.askPayerPhone = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's phone required, <c>false</c> to not.</returns>
    public bool AskPayerPhone()
    {
      return this.askPayerPhone;
    }

    /// <summary>
    ///   <para>Whether to allow payer specify custom payment purpose text (<c>true</c>) or use predefined purpose text (<c>false</c>). Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer specify payment purpose, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerPurpose(bool ask)
    {
      this.askPayerPurpose = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to allow payer specify custom payment purpose text (<c>true</c>) or use predefined purpose text (<c>false</c>). Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to allow payer specify payment purpose, <c>false</c> to not.</returns>
    public bool AskPayerPurpose()
    {
      return this.askPayerPurpose;
    }

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget Sum(decimal sum)
    {
      this.sum = sum;
      return this;
    }
    
    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <returns>Payment sum.</returns>
    public decimal? Sum()
    {
      return this.sum;
    }

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Pay").</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget Text(byte text)
    {
      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Pay").</para>
    /// </summary>
    /// <returns>Numeric code of text to display.</returns>
    public byte Text()
    {
      return this.text;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty() || this.Description().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("iframe")
        .Attribute("src", "https://money.yandex.ru/embed/shop.xml?account={0}&quickpay=shop{1}&writer={2}&{3}={4}&default-sum={5}&button-text=0{6}{7}{8}{9}{10}{11}".FormatSelf(this.Account(), this.Cards() ? "&payment-type-choice=on" : string.Empty, this.AskPayerPurpose() ? "buyer" : "seller", this.AskPayerPurpose() ? "targets-hint" : "targets", this.Description(), this.Sum(), this.Text(), this.AskPayerComment() ? "&comment=on" : string.Empty, this.AskPayerFullName() ? "&fio=on" : string.Empty, this.AskPayerEmail() ? "&mail=on" : string.Empty, this.AskPayerPhone() ? "&phone=on" : string.Empty, this.AskPayerAddress() ? "&address=on" : string.Empty))
        .Attribute("frameborder", 0)
        .Attribute("allowtransparency", true)
        .Attribute("scrolling", "no")
        .Attribute("width", 450)
        .Attribute("height", this.AskPayerComment() ? 255 : 200)
        .ToString();
    }
  }
}