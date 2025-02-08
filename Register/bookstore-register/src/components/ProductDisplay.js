import React from "react";
import ProductInfo from "../models/ProductInfo";
import "./ProductDisplay.css";
import { toMoney } from "../util/MoneyMethods";
import ProductCategory from "../models/ProductCategory";

class ProductDisplayProps {
  /** @type {ProductInfo} */
  Product;
  /** @type {boolean} */
  EditMode;
  OnProductChanged;

  form;
  setForm;
}

/**
 *
 * @param {ProductDisplayProps} props
 */
export default function ProductDisplay(props) {


  const handleInputChange = (e) => {
    const { name, value } = e.target;
    props.setForm({
      ...props.form,
      [name]: value,
    });
  };

  const handleInputNumberChange = (e) => {
    const { name, value } = e.target;
    props.setForm({
      ...props.form,
      [name]: parseFloat(value),
    });
  }

  if (props.Product || props.form) {
    let upcFragment;
    let priceFragment;
    let nameFragment;
    let categoryFragment;
    let descriptionFragment;
    let stockFragment;

    if (props.form) {
      upcFragment = (
        <input
          type="text"
          name="upc"
          value={props.form.upc}
          onChange={handleInputChange}
        />
      );
      priceFragment = (
        <input
          type="number"
          name="price"
          value={props.form.price}
          onChange={handleInputNumberChange}
        />
      );
      nameFragment = (
        <input
          type="text"
          name="name"
          value={props.form.name}
          onChange={handleInputChange}
        />
      );
      categoryFragment = (
        <select
          name="category"
          value={props.form.category}
          onChange={handleInputChange}
        >
          {ProductCategory.entries().map(([k,v]) => (
            <option key={k} value={k}>
              {v}
            </option>
          ))}
        </select>
      );
      descriptionFragment = (
        <textarea
          name="description"
          value={props.form.description}
          onChange={handleInputChange}
        />
      );
      stockFragment = (
        <input
          type="number"
          name="stock"
          value={props.form.stock}
          onChange={handleInputNumberChange}
        />
      );
    } else {
      upcFragment = <div>{props.Product.upc}</div>;
      priceFragment = <div>{toMoney(props.Product.price)}</div>;
      nameFragment = <div>{props.Product.name}</div>;
      categoryFragment = <div>{ProductCategory.get(props.Product.category)}</div>;
      descriptionFragment = <div>{props.Product.description}</div>;
      stockFragment = <div>{props.Product.stock}</div>;
    }

    return (
      <>
        <div className="product-display">
          <div className="field-wrapper col-span-3">
            <strong className="strong-label">UPC</strong>
            <div>{props.Product?.upc}</div>
          </div>
          <div className="field-wrapper col-span-1">
            <strong className="strong-label">Category</strong>
            {categoryFragment}
          </div>
          <div className="field-wrapper col-span-4">
            <strong className="strong-label">Name</strong>
            {nameFragment}
          </div>
          <div className="field-wrapper col-span-4">
            <strong className="strong-label">Description</strong>
            {descriptionFragment}
          </div>
          <div className="field-wrapper col-span-2">
            <strong className="strong-label">Price</strong>
            {priceFragment}
          </div>
          <div className="field-wrapper col-span-2">
            <strong className="strong-label">Stock</strong>
            {stockFragment}
          </div>
          <div className="field-wrapper col-span-2">
            <strong className="strong-label">Stock Date</strong>
            <div>{props.Product?.stock_date ?? "N/A"}</div>
          </div>
          <div className="field-wrapper col-span-2">
            <strong className="strong-label">Last Sold</strong>
            <div>{props.Product?.last_sold ?? "N/A"}</div>
          </div>
        </div>
      </>
    );
  } else {
    return <></>;
  }
}
