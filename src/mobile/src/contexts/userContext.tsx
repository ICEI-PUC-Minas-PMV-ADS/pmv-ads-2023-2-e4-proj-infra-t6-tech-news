import React, {
  createContext,
  useState,
  useContext,
  Dispatch,
  ReactNode,
} from 'react';

interface UserProviderProps {
  children: ReactNode;
}

interface UserContextType {
  signed: boolean;
  setSigned?: Dispatch<React.SetStateAction<boolean>>;
  userId: number;
  setUserId?: Dispatch<React.SetStateAction<number>>;
  userEmail: string;
  setUserEmail?: Dispatch<React.SetStateAction<string>>;
}

export const UserContext = createContext<UserContextType>({
  signed: false,
  userId: 0,
  userEmail: '',
});

export default function UserProvider({ children }: UserProviderProps) {
  const [signed, setSigned] = useState(false);
  const [userId, setUserId] = useState(0);
  const [userEmail, setUserEmail] = useState('');

  const value: UserContextType = {
    signed,
    setSigned,
    userId,
    setUserId,
    userEmail,
    setUserEmail
  };

  return <UserContext.Provider value={value}>{children}</UserContext.Provider>;
}

export function useUser() {
  const context = useContext(UserContext);

  const { signed, setSigned, userId, setUserId, userEmail, setUserEmail } = context;

  return { signed, setSigned, userId, setUserId, userEmail, setUserEmail };
}