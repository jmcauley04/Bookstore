import React, { Fragment } from "react";
import "./Cart.css";
import ProductInfo from "../models/ProductInfo";
import ShoppingCart from "../models/ShoppingCart";
import {toMoney} from "../util/MoneyMethods";

class CartProps {
    /** @type {ProductInfo} */
    selectedProduct;
    setSelectedProduct
    /** @type {ShoppingCart} */
    shoppingCart;
    removeItem;
    clearAll;
    checkout;
}

/**
 * 
 * @param {CartProps} CartProps 
 */
export default function Cart(CartProps) {
  return (
    <div className="cart">
      <div className="item-list-wrapper">
        <div className="header">
          <div className="text">Product</div>
          <div>Price</div>
          <div>Qty</div>
          <div>Total</div>
        </div>
        <div className="item-list">
          {CartProps.shoppingCart.getProducts().map(({productInfo, quantity}) => (
            <Fragment key={productInfo.id}>
              <div className="item-row" onClick={() => CartProps.setSelectedProduct(productInfo)} style={{backgroundColor: productInfo.id === CartProps.selectedProduct?.id ? 'var(--shade-dark)' : null}}>
                <div className="text">
                  <div className="product-name">{productInfo.name}</div>
                  <div className="product-desc">{productInfo.description}</div>
                </div>
                <div>{toMoney(productInfo.price)}</div>
                <div>{quantity}</div>
                <div>{toMoney(productInfo.price * quantity)}</div>
              </div>
              <div className="hr" />
            </Fragment>
          ))}
        </div>
        <div className="end-line">
            <div>Subtotal</div>
            <div>{toMoney(CartProps.shoppingCart.getTotalPrice())}</div>
        </div>
        <div className="end-line">
            <div>Tax</div>
            <div>{toMoney(CartProps.shoppingCart.getTax())}</div>
        </div>
        <div className="end-line">
            <div>Total</div>
            <div className="total">{toMoney(CartProps.shoppingCart.getTotalWithTax())}</div>
        </div>
      </div>
      <div className="buttons-row">
        <button className="btn btn-checkout" onClick={CartProps.checkout}>Checkout</button>
        <button className="btn" onClick={() => CartProps.removeItem(CartProps.selectedProduct)}>Remove Item</button>        
        <button className="btn" onClick={CartProps.clearAll}>Clear All</button>
      </div>
    </div>
  );
}
