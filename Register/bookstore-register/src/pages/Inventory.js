import React from "react";
import { useState, useEffect } from "react";
import ProductLookupService from "../services/ProductLookupService";
import "./Inventory.css";
import UPCScan from "../components/UPCScan";
import ProductDisplay from "../components/ProductDisplay";
import ProductInfo from "../models/ProductInfo";
import Dialog from "../components/Dialog";

export default function Inventory() {
  const [selectedProduct, setSelectedProduct] = useState(null);
  const productLookupService = new ProductLookupService();
  const [dialogOpen, setDialogOpen] = useState(false);
  const [scannedUPC, setScannedUPC] = useState(null);

  const [form, setForm] = useState({
    upc: "",
    price: 0,
    name: "",
    category: "",
    description: "",
    stock: "",
    stock_date: "",
    last_sold: "",
  });

  useEffect(() => {
    let product = new ProductInfo();
    if (selectedProduct) {
      product = selectedProduct;
    }

    setForm({
      upc: product.upc,
      price: product.price ?? 0,
      name: product.name ?? "",
      category: product.category ?? "",
      description: product.description ?? "",
      stock: product.stock ?? "",
      stock_date: product.stock_date ?? "",
      last_sold: product.last_sold ?? "",
    });
  }, [selectedProduct]);

  const onProductScanned = async (upc) => {
    const product = await productLookupService.getProductByUPC(upc);
    if (product) {
      setSelectedProduct(product);
    } else {
        setScannedUPC(upc);
        setDialogOpen(true);        
    }
  };

  const addNewProduct = () => {
    const product = new ProductInfo();
    product.upc = scannedUPC;
    setSelectedProduct(product);
    setDialogOpen(false);     
  }

  const onSubmit = async () => {
    console.log(form);
    // const product = await productLookupService.getProductByUPC(form.upc);
    // if (product) {
    //   setSelectedProduct(product);
    // } else {
    //   setSelectedProduct(null);
    //   throw new Error("Product not found");
    // }
  };

  return (
    <>
      <div className="inventory">
        <div className="inventory-form">
          <UPCScan onSubmit={onProductScanned} />
          <ProductDisplay
            Product={selectedProduct}
            form={form}
            setForm={setForm}
          />
          <button
            className="btn"
            style={{ marginTop: "1em" }}
            onClick={onSubmit}
          >
            Submit
          </button>
        </div>
      </div>
      <Dialog
        DialogType="confirm"
        Title="Product not found"
        Message="Would you like to add this product?"
        Open={dialogOpen}
        OnCancel={() => setDialogOpen(false)}
        OnOk={addNewProduct}
      />
    </>
  );
}
