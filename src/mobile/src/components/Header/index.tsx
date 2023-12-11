import { TouchableOpacity } from 'react-native';
import { useNavigation, useRoute } from '@react-navigation/native';

import { Logo } from '@components/Logo';
import { useUser } from '@contexts/userContext';
import { logout } from '@lib/sessionService';

import {
  Container,
  BackIcon,
  BackButton,
  SignOutIcon,
  SignOutButton,
} from './styles';

type HeaderProps = {
  showBackButton?: boolean;
  showSignOutButton?: boolean;
  showLogo?: boolean;
};

export function Header({
  showBackButton = false,
  showSignOutButton = false,
  showLogo = true,
}: HeaderProps) {
  const navigation = useNavigation();
  const route = useRoute();
  const { setSigned, setUserId, setUserEmail } = useUser();

  async function handleLogOut() {
    await logout();

    setSigned?.(false);
    setUserId?.(0);
    setUserEmail?.('');
  }

  function handleGoBack() {
    navigation.goBack();
  }

  function handleGoToNewsList() {
    if (route.name === 'news') return;

    navigation.navigate('news');
  }

  return (
    <Container>
      {showBackButton && (
        <BackButton onPress={handleGoBack}>
          <BackIcon />
        </BackButton>
      )}
      {showSignOutButton && (
        <SignOutButton onPress={handleLogOut}>
          <SignOutIcon />
        </SignOutButton>
      )}
      {showLogo && (
        <TouchableOpacity onPress={handleGoToNewsList}>
          <Logo size={showBackButton ? 56 : 84} />
        </TouchableOpacity>
      )}
    </Container>
  );
}
