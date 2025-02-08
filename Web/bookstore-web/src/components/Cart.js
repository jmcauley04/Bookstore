import React from 'react'
import SVGCart from '../icons/SVGCart'
import './Cart.css'

class CartProps {
    /** @type {number} */
    items = 0;
}

/** @param {CartProps} cartProps  */
export default function Cart(cartProps) {
    const items = cartProps.items ?? 0;
  return (
    <div className="cart" data-items={items}>
      <SVGCart />
    </div>
  )
}
