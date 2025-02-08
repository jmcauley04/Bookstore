import Cart from "../components/Cart";
import "./Register.css";
import UPCScan from "../components/UPCScan";
import ProductDisplay from "../components/ProductDisplay";
import { useState } from "react";
import ProductLookupService from "../services/ProductLookupService";
import ShoppingCart from "../models/ShoppingCart";

export default function Register() {
  const [selectedProduct, setSelectedProduct] = useState(null);
  const [shoppingCart, setShoppingCart] = useState(new ShoppingCart());
  const [itemLookupOnly, setItemLookupOnly] = useState(false);
  const productLookupService = new ProductLookupService();

  const applyCartUpdates = () => {
    setShoppingCart(shoppingCart.getClone());
  }

  const removeItem = (product) => {
    if (!product) return;
    shoppingCart.removeProduct(product.id, 1);
    applyCartUpdates();
    if (shoppingCart.productQuantities[product.id] == null) {
      console.log("set selected product to null");
      setSelectedProduct(null);
    }
  };

  const clearAll = () => {
    console.log("clear all");
    setShoppingCart(new ShoppingCart());
  };

  const checkout = () => {
    console.log("checkout", shoppingCart.getProducts());
  };

  const addProduct = async (upc) => {
    const product = await productLookupService.getProductByUPC(upc);
    if (product) {
      setSelectedProduct(product);
      if(!itemLookupOnly){
          shoppingCart.addProduct(product, 1);
          applyCartUpdates();
      }
    } else {
      setSelectedProduct(null);
      throw new Error("Product not found");
    }
  };

  return (
    <>
      <div className="register">
        <div className="register-form">
          <div className="grid" style={{ position: "relative" }}>
            <UPCScan onSubmit={addProduct} />
            <label style={{position: "absolute", top: 0, right: 0}} className="label-checkbox">
              <input type="checkbox" checked={itemLookupOnly} onChange={(e) => setItemLookupOnly(e.target.checked)} />
              <strong className="strong-label no-select" style={{ fontWeight: 600 }}>
                Item lookup only
              </strong>
            </label>
          </div>
          <ProductDisplay Product={selectedProduct} />
        </div>
        <div>
          <Cart
            setSelectedProduct={setSelectedProduct}
            selectedProduct={selectedProduct}
            shoppingCart={shoppingCart}
            removeItem={removeItem}
            clearAll={clearAll}
            checkout={checkout}
          />
        </div>
      </div>
    </>
  );
}
