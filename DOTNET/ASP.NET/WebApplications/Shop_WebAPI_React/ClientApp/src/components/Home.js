import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div className="text-center">
                <h1 className="display-4">Welcome</h1>
                <div className="text-left">
                    You are invited to create your own eshop on our platform.

                    With our easy-to-use tools and features, you can showcase your products and services to millions of customers worldwide.
                    Whether you want to sell clothes, books, electronics,
                    or anything else,
                    we have the perfect solution for you.
                    To get started, simply click on the link below and follow the instructions.
                    You will be able to customize your eshop with your own logo, colors, and design.
                    You will also have access to analytics, marketing, and customer support.
                    Don't miss this opportunity to grow your business online.

                    Create your eshop today!
                </div>
            </div>

        );
    }
}
