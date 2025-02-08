import React from "react";
import Banner from "../../Sections/Banner";
import SplitContent from "../../Sections/SplitContent";
import CenterContent from "../../Sections/CenterContent";

export default function Home() {
  return (
    <>
      <Banner text="Speak to a real life human when you have concerns or suggestions.  Review our Contact Us page today!" />
      <CenterContent
        title="Grand Opening!"
        text="We are so excited to share our curated collection of books with you!  We have something for everyone, so take a look around and find your next favorite read."
      />
      <Banner text="Don't miss our grand opening sale where you can get 10% off orders over $40!" />
      <SplitContent
        title="Love is all around"
        text="Whether you choose to celebrate Valentine's Day or not, there's no bad time to celebrate love!"
        button="Shop Now"
        image="https://i.pinimg.com/originals/f3/9e/ce/f39ece08880a4c0ab931501bbd497e1a.jpg"
        imageOnLeft={false}
        url="www.google.com"
      />
      <CenterContent
        bgFilled={true}
        title="Hey Biggest Fans!"
        text="Is your favorite author missing from our selection? Place a request to have it added and we'll do our best to accomodate!"
      />

      <SplitContent
        title="Love is all around"
        text="Whether you choose to celebrate Valentine's Day or not, there's no bad time to celebrate love!"
        button="Shop Now"
        image="https://i.pinimg.com/originals/f3/9e/ce/f39ece08880a4c0ab931501bbd497e1a.jpg"
        imageOnLeft={true}
        url="www.google.com"
      />
      <Banner text="Be surprised by our curated selections delivered directly to your abode.  Subscribe for a Blind Date with a book today!" />

      <CenterContent
        title="Hey"
        text="You're doing great!"
      />

      <Banner text="Are you an author looking to get your content out there? We'd love to collaborate with you!" />

    </>
  );
}
