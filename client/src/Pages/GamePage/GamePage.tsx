import React, { useEffect, useState } from 'react';
import Navbar from '../../Components/Navbar/Navbar';

const GamePage = () => {
  const [image1, setImage1] = useState<string | null>(null);
  const [image2, setImage2] = useState<string | null>(null);

  useEffect(() => {
    // Fetch image 1
    fetch('http://localhost:5227/server/map/id/3')
      .then(response => response.json())
      .then(data => setImage1(data.image))
      .catch(error => console.error('Error fetching image 1:', error));

    // Fetch image 2
    fetch('http://localhost:5227/server/map/id/3')
      .then(response => response.json())
      .then(data => setImage2(data.image))
      .catch(error => console.error('Error fetching image 2:', error));
  }, []);

  return (
    <div>
      <Navbar />
      <h2>Welcome to MapleGuessr!</h2>
      <p>Start exploring and guess the locations on the map.</p>
      <div className="game-images">
        {image1 && <img src={image1} alt="Location 1" className="game-image" />}
        {image2 && <img src={image2} alt="Location 2" className="game-image" />}
      </div>
    </div>
  );
};

export default GamePage;
