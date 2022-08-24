[Point](../../Point.md) > [Parameter](../Parameter.md) > [Humidity_Parameter](Humidity_Parameter.md) > [High_Humidity_Alarm_Parameter](.)
# High_Humidity_Alarm_Parameter
**DTMI:** dtmi:org:brickschema:schema:Brick:High_Humidity_Alarm_Parameter;1
## Display name
- **en:** High Humidity Alarm Parameter
## Description
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
