import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { Login } from '@screens/Login';
import { News } from '@screens/News';

import { useUser } from '../contexts/userContext';
import { SignUp } from '@screens/SignUp';
import { AddNew } from '@screens/AddNew';
import { MyNews } from '@screens/MyNews';

const { Navigator, Screen } = createNativeStackNavigator();

export function AppRoutes() {
  const { signed } = useUser();

  return (
    <Navigator
      screenOptions={{
        headerShown: false,
        contentStyle: {
          backgroundColor: 'transparent',
        },
      }}
    >
      {signed ? (
        <>
          <Screen name="news" component={News} />
          <Screen name="addNew" component={AddNew} />
          <Screen name="myNews" component={MyNews} />
        </>
      ) : (
        <>
          <Screen name="login" component={Login} />
          <Screen name="signUp" component={SignUp} />
        </>
      )}
    </Navigator>
  );
}