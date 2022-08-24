[Point](../../Point.md) > [Parameter](../Parameter.md) > [Temperature_Parameter](Temperature_Parameter.md) > [High_Temperature_Alarm_Parameter](#)
# High_Temperature_Alarm_Parameter

**Display name:** High Temperature Alarm Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:High_Temperature_Alarm_Parameter;1

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
