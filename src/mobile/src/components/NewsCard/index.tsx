import { TouchableOpacityProps, Linking, Text } from 'react-native';
import {
  Container,
  Icon,
  Title,
  Author,
  InnerContainer,
  Row,
  Placeholder,
} from './styles';
import { useUser } from '@contexts/userContext';
import { EditButton } from '@components/EditButton';

type NewsCardProps = TouchableOpacityProps & {
  title: string;
  link: string;
  author: string;
  onEditPress: () => void;
};

export function NewsCard({
  title,
  link,
  author,
  onEditPress,
  ...rest
}: NewsCardProps) {
  const { userEmail } = useUser();
  return (
    <Container {...rest}>
      <InnerContainer>
        <Row>
          <Icon />
          <Text style={{ color: 'blue' }} onPress={() => Linking.openURL(link)}>
            <Title>{title}</Title>
          </Text>
        </Row>
        <Row>
          {author === userEmail ? (
            <EditButton onPress={onEditPress} />
          ) : (
            <Placeholder />
          )}
          <Author>{'Compartilhado por:\n' + author}</Author>
        </Row>
      </InnerContainer>
    </Container>
  );
}
