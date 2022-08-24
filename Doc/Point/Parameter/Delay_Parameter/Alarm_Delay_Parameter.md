[Point](../../Point.md) > [Parameter](../Parameter.md) > [Delay_Parameter](Delay_Parameter.md) > [Alarm_Delay_Parameter](#)
# Alarm_Delay_Parameter

**Display name:** Alarm Delay Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Alarm_Delay_Parameter;1

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
