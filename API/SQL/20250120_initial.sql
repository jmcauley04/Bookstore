CREATE TABLE bookmarked.transact.transactions (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    timestamp TIMESTAMP NOT NULL,
    amount NUMERIC(15, 2) NOT NULL,
    type INT NOT NULL,
    category_id INT NOT NULL,
    comments VARCHAR(1000)
);

DROP TABLE bookmarked.transact.transactions_store_merch;
CREATE TABLE bookmarked.transact.transactions_store_merch (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    transaction_id INT NOT NULL REFERENCES bookmarked.transact.transactions(id),
    store_id INT NOT NULL,
    associate_id INT NOT NULL,
    customer_id INT NOT NULL
);

CREATE TABLE bookmarked.transact.transactions_purchase (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    transaction_id INT NOT NULL REFERENCES bookmarked.transact.transactions(id),
    product_id INT NOT NULL REFERENCES bookmarked.entities.products(id),
    quantity INT NOT NULL
);


CREATE TABLE bookmarked.entities.stores (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(100) NOT NULL,
    address_id INT NOT NULL REFERENCES bookmarked.entities.addresses(id)
);

CREATE TABLE bookmarked.entities.addresses (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    street VARCHAR(100) NOT NULL,
    city VARCHAR(100) NOT NULL,
    state VARCHAR(20) NOT NULL,
    zip VARCHAR(20) NOT NULL
);

CREATE TABLE bookmarked.entities.customers (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    email VARCHAR(100),
    name VARCHAR(100),
    phone VARCHAR(15),
    address_id INT REFERENCES bookmarked.entities.addresses(id)   
);

CREATE TABLE bookmarked.entities.associates (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    title VARCHAR(100) NOT NULL,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone VARCHAR(100) NOT NULL,
    address_id INT REFERENCES bookmarked.entities.addresses(id)   
);

CREATE TABLE bookmarked.entities.products (
    id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,    
    name VARCHAR(100) NOT NULL,
    description VARCHAR(100) NOT NULL,
    price NUMERIC(15, 2) NOT NULL
);

CREATE TABLE bookmarked.entities.registers (
    store_id INT NOT NULL,
    register_id INT NOT NULL,
    created_at TIMESTAMP NOT NULL,
    updated_at TIMESTAMP NOT NULL,
    cash_amt NUMERIC(15, 2) NOT NULL,
    check_amt NUMERIC(15, 2) NOT NULL,
    credit_amt NUMERIC(15, 2) NOT NULL,
    PRIMARY KEY (store_id, register_id)
);