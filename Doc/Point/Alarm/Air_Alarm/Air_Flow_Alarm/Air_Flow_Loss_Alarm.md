[Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Air_Alarm](../Air_Alarm.md) > [Air_Flow_Alarm](Air_Flow_Alarm.md) > [Air_Flow_Loss_Alarm](#)
# Air_Flow_Loss_Alarm

**Display name:** Air Flow Loss Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Loss_Alarm;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
