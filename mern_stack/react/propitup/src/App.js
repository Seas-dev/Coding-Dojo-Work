import React from 'react';
import './App.css';
import PersonCard from './components/PersonCard';

function App() {
  return (
    <div className="App">
      <PersonCard firstName="Jane" lastName="Doe" age="45" hairColor="Black" />
      <PersonCard firstName="John" lastName="Smith" age="88" hairColor="Grey" />
      <PersonCard firstName="Millard" lastName="Fillmore" age="50" hairColor="Brown" />
      <PersonCard firstName="Maria" lastName="SMith" age="62" hairColor="Brunette" />
    </div>
  );
}

export default App;
